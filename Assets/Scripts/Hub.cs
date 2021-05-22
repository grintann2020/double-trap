using System;
using UnityEngine;

namespace T {

    public class Hub {

        public bool IsConn { get { return _isConn; } }
        protected delegate void _dAct();
        protected delegate void _dMot(); // step
        protected delegate bool _dFrg(); // forgo
        protected _dAct[] _actArr;
        protected _dMot[] _motArr;
        protected _dFrg[] _frgArr;
        protected GameObject[] _goArr;
        protected object[] _valArr;
        private bool[] _mtvArr;
        private bool _isConn;
        private byte _eMot;

        public virtual void Conn() {
            _isConn = true;
            RstArr();
        }

        public virtual void Dscn() {
            _isConn = false;
            RstArr();
        }

        public void InvkUpd() {
            if (_isConn == false) {
                return;
            }
            if (_mtvArr[_eMot] == true) {
                if (_motArr[_eMot] != null) {
                    _motArr[_eMot].Invoke();
                }
                if (_frgArr[_eMot].Invoke()) {
                    _mtvArr[_eMot] = false;
                }
            }
        }

        public void Act(byte eAct) {
            _actArr[eAct]();
        }

        public void Mot(byte eMot) {
            if (_mtvArr[eMot] == false) {
                _mtvArr[_eMot] = false;
                _mtvArr[eMot] = true;
                _eMot = eMot;
            }
        }

        public void StGO(byte eGO, GameObject go) {
            _goArr[eGO] = go;
        }

        public GameObject GtGO(byte eGO) {
            return _goArr[eGO];
        }

        public void StVal<T>(byte eVal, T val) {
            _valArr[eVal] = val;
        }

        public T GtVal<T>(byte eVal) {
            return (T)_valArr[eVal];
        }

        private void RstArr() {
            _mtvArr = new bool[_motArr.Length];
            for (byte g = 0; g < _goArr.Length; g++) {
                _goArr[g] = null;
            }
            for (byte v = 0; v < _valArr.Length; v++) {
                _valArr[v] = null;
            }
            for (byte m = 0; m < _motArr.Length; m++) {
                _mtvArr[m] = false;
            }
        }
    }
}
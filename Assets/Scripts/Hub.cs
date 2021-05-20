using System;
using UnityEngine;

namespace T {

    public class Hub {

        public bool IsConn { get { return _isConn; } }
        protected GameObject[] _goArr;
        private bool _isConn;

        public virtual void Conn() {
            _isConn = true;
            for (byte g = 0; g < _goArr.Length; g++) {
                _goArr[g] = null;
            }
        }

        public virtual void Dscn() {
            _isConn = false;
            for (byte g = 0; g < _goArr.Length; g++) {
                _goArr[g] = null;
            }
        }

        public void InvkUpd() {
            if (_isConn == false) {
                return;
            }
        }

        public void St(byte eGO, GameObject go) {
            _goArr[eGO] = go;
        }

        public GameObject Gt(byte eGO) {
            return _goArr[eGO];
        }
    }
}
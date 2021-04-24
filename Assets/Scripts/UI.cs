using System;
using UnityEngine;

namespace T {

    public class UI {

        public bool IsInstl { get { return _isInstl; } }
        protected Canvas _canv;
        protected string[] _keyArr;
        protected GameObject[] _setArr;
        protected object[][] _elemArr;
        protected delegate void _bss();
        protected _bss[] _bssArr;
        private bool _isInstl = false;
        // _elemArr[(byte)ERes][0] --> unknown) Component
        // _elemArr[(byte)ERes][1] --> enum) ERes
        // _elemArr[(byte)ERes][2] --> string) name of reference GameObject
        // _elemArr[(byte)ERes][3] --> Type) type of Component

        public void SetCanv(Canvas canv) {
            _canv = canv;
        }

        public void Instl() {
            ResMgr.Ins.Inst(_keyArr, (GameObject[] resArr) => {
                for (byte r = 0; r < resArr.Length; r++) {
                    _setArr[r] = resArr[r];
                }
                for (byte e = 0; e < _elemArr.Length; e++) {
                    _elemArr[e][0] = GameObject.Find(_setArr[(byte)_elemArr[e][1]].name + "/" + (string)_elemArr[e][2]).GetComponent((Type)_elemArr[e][3]);
                }
                for (byte b = 0; b < _bssArr.Length; b++) {
                    if (_bssArr[b] != null) {
                        _bssArr[b].Invoke();
                    }
                }
                _isInstl = true;
            }, _canv.transform);
        }

        public void Unstl() {
            ResMgr.Ins.Rls<GameObject>(_setArr, () => {
                for (byte s = 0; s < _setArr.Length; s++) {
                    _setArr[s] = null;
                }
                for (byte e = 0; e < _elemArr.Length; e++) {
                    _elemArr[e][0] = null;
                }
                _isInstl = false;
            });
        }

        public void Enbl() {
            for (byte s = 0; s < _setArr.Length; s++) {
                _setArr[s].SetActive(true);
            }
        }

        public void Dsbl() {
            for (byte s = 0; s < _setArr.Length; s++) {
                _setArr[s].SetActive(false);
            }
        }

        public void EnblSet(byte eSet) {
            _setArr[eSet].SetActive(true);
        }

        public void DsblSet(byte eSet) {
            _setArr[eSet].SetActive(false);
        }

        public void EnblElem(byte eRef) {
            ((Component)_elemArr[eRef][0]).gameObject.SetActive(true);
        }

        public void DsblElem(byte eRef) {
            ((Component)_elemArr[eRef][0]).gameObject.SetActive(false);
        }
    }
}
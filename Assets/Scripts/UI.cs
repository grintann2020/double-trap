using System;
using UnityEngine;

namespace T {

    public class UI {

        protected Canvas _canv;
        protected string[] _keyArr;
        protected GameObject[] _setArr;
        protected object[][] _elemArr;
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
                for (byte r = 0; r < _elemArr.Length; r++) {
                    _elemArr[r][0] = GameObject.Find(_setArr[(byte)_elemArr[r][1]].name + "/" + (string)_elemArr[r][2]).GetComponent((Type)_elemArr[r][3]);
                }
            }, _canv.transform);
        }

        public void Unstl() {
            ResMgr.Ins.Rls<GameObject>(_setArr, () => {
                for (byte r = 0; r < _setArr.Length; r++) {
                    _setArr[r] = null;
                }
                for (byte r = 0; r < _elemArr.Length; r++) {
                    _elemArr[r][0] = null;
                    _elemArr[r][1] = null;
                }
            });
        }

        public void Enbl() {
            for (byte r = 0; r < _setArr.Length; r++) {
                _setArr[r].SetActive(true);
            }
        }

        public void Dsbl() {
            for (byte r = 0; r < _setArr.Length; r++) {
                _setArr[r].SetActive(false);
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
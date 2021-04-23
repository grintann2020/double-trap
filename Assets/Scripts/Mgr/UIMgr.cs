using UnityEngine;

namespace T {

    public class UIMgr : Sgltn<UIMgr> {

        private IUI[] _iUIArr;

        public void Bind(IUIPrm iUIPrm) {
            _iUIArr = iUIPrm.IUIArr;
        }

        public void Init() {

        }

        public void SetCanv(byte eUI, Canvas canv) {
            _iUIArr[eUI].SetCanv(canv);
        }

        public IUI GetUI(byte eUI) {
            return _iUIArr[eUI];
        }

        public void Instl(byte eUI) {
            _iUIArr[eUI].Instl();
        }

        public void Unstl(byte eUI) {
            _iUIArr[eUI].Unstl();
        }

        public void Enbl(byte eUI) {
            _iUIArr[eUI].Enbl();
        }

        public void Dsbl(byte eUI) {
            _iUIArr[eUI].Dsbl();
        }

        public void EnblSet(byte eUI, byte eSet) {
            _iUIArr[eUI].EnblSet(eSet);
        }

        public void DsblSet(byte eUI, byte eSet) {
            _iUIArr[eUI].DsblSet(eSet);
        }

        public void EnblElem(byte eUI, byte eElem) {
            _iUIArr[eUI].EnblElem(eElem);
        }

        public void DsblElem(byte eUI, byte eElem) {
            _iUIArr[eUI].DsblElem(eElem);
        }
    }
}
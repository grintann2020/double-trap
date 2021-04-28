using UnityEngine;

namespace T {

    public class UIMgr : Sgltn<UIMgr> {

        private IUI[] _iUIArr;

        public void Bind(IUIPrm iUIPrm) {
            _iUIArr = iUIPrm.IUIArr;
        }

        public void Init() {

        }

        public void InvkUpd() { 
            // Debug.Log("UIMgr -- InvkUpd");
            for (byte u = 0; u < _iUIArr.Length; u++) {
                if (_iUIArr[u].IsInstl) {
                    _iUIArr[u].InvkUpd();
                }
            }
        }

        public void Canv(byte eUI, Canvas canv) {
            _iUIArr[eUI].Canv(canv);
        }

        public IUI UI(byte eUI) {
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

        public void Enbl(byte eUI, byte eSet) {
            _iUIArr[eUI].Enbl(eSet);
        }

        public void Dsbl(byte eUI, byte eSet) {
            _iUIArr[eUI].Dsbl(eSet);
        }

        public void EnblElem(byte eUI, byte eElem) {
            _iUIArr[eUI].EnblElem(eElem);
        }

        public void DsblElem(byte eUI, byte eElem) {
            _iUIArr[eUI].DsblElem(eElem);
        }

        public void Front(byte eUI) {
            _iUIArr[eUI].Front();
        }

        public void Front(byte eUI, byte eSet) {
            _iUIArr[eUI].Front(eSet);
        }

        public void Back(byte eUI) {
            _iUIArr[eUI].Back();
        }

        public void Back(byte eUI, byte eSet) {
            _iUIArr[eUI].Back(eSet);
        }
    }
}
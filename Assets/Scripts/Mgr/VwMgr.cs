using UnityEngine;

namespace T {

    public class VwMgr : Sgltn<VwMgr> {

        private IVw[] _iVwArr;

        public void Bind(IVwPrm iVwPrm) {
            _iVwArr = iVwPrm.IVwArr;
        }

        public void Init() {

        }

        public void InvkUpd() {
            for (byte v = 0; v < _iVwArr.Length; v++) {
                _iVwArr[v].InvkUpd();
            }
        }

        public void Stup(byte eVw, Camera cam) {
            _iVwArr[eVw].Stup(cam);
        }

        public void Stdn(byte eVw) {
            _iVwArr[eVw].Stdn();
        }

        public void Prj(byte eVw, byte ePrj) {
            _iVwArr[eVw].Prj(ePrj);
        }

        public void Ornt(byte eVw, byte eOrnt) {
            _iVwArr[eVw].Ornt(eOrnt);
        }
        
        public void Mov(byte eVw, byte eMov) {
            _iVwArr[eVw].Mov(eMov);
        }

        public IVw Vw(byte eVw) {
            return _iVwArr[eVw];
        }

        public bool IsStup(byte eVw) {
            return _iVwArr[eVw].IsStup;
        }
    }
}
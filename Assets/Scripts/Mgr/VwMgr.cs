using UnityEngine;

namespace T {

    public class VwMgr : Sgltn<VwMgr> {

        // private SCamPrj[] _sPrjArr;
        private IVw[] _iVwArr;

        public void Bind(IVwPrm iVwPrm) {
            // _sPrjArr = iVwPrm.SPrjArr;
            _iVwArr = iVwPrm.IVwArr;
        }

        public void Init() {

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

        public IVw Vw(byte eVw) {
            return _iVwArr[eVw];
        }

        // public void Disp(byte eVw, byte eAct) {
        //     _iVwArr[eVw].Disp(eAct);
        // }
    }
}
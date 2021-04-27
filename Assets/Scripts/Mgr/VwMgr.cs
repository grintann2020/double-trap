using UnityEngine;

namespace T {

    public class VwMgr : Sgltn<VwMgr> {

        private SCamPrj[] _sPrjArr;
        private IVw[] _iVwArr;

        public void Bind(IVwPrm iVwPrm) {
            _sPrjArr = iVwPrm.SPrjArr;
            _iVwArr = iVwPrm.IVwArr;
        }

        public void Init() {

        }

        public void Cam(byte eVw, Camera cam) {
            _iVwArr[eVw].Cam(cam);
        }

        public void Prj(byte eVw, byte ePrj) {
            _iVwArr[eVw].Prj(_sPrjArr[ePrj]);
        }

        public IVw Vw(byte eVw) {
            return _iVwArr[eVw];
        }

        public void Chg(byte eVw, byte eAct) {
            _iVwArr[eVw].Chg(eAct);
        }
    }
}
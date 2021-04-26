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

        public void SetCam(byte eVw, Camera cam) {
            _iVwArr[eVw].SetCam(cam);
        }

        public void SetPrj(byte eVw, byte ePrj) {
            _iVwArr[eVw].SetPrj(_sPrjArr[ePrj]);
        }

        public IVw GetVw(byte eVw) {
            return _iVwArr[eVw];
        }

        public void Act(byte eVw, byte eAct) {
            _iVwArr[eVw].Act(eAct);
        }
    }
}
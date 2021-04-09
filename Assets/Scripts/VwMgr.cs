using UnityEngine;

namespace T {

    public class VwMgr : Singleton<VwMgr> {

        private SCamPrj[] _sCamPrjArr;
        private IVw[] _iVwArr;

        public void Bind(IVwPrm iVwPrm) {
            _sCamPrjArr = iVwPrm.SCamPrjArr;
            _iVwArr = iVwPrm.IVwArr;
        }

        public void Init() {

        }

        public void SetCam(byte eVw, Camera cam) {
            _iVwArr[eVw].SetCam(cam);
        }

        public void SetCamPrj(byte eVw, byte eCamPrj) {
            _iVwArr[eVw].SetCamPrj(_sCamPrjArr[eCamPrj]);
        }

        public IVw Get(byte eVw) {
            return _iVwArr[eVw];
        }

        public void Act(byte eVw, byte eAct) {
            _iVwArr[eVw].Act(eAct);
        }
    }
}
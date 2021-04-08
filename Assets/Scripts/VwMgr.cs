using System;
using UnityEngine;

namespace T {

    public class VwMgr : Singleton<VwMgr> {

        private SCamPrj[] _sCamPrjArr;
        private IVw[] _iVwArr;
        // private IVw _iCurrVw;

        public void Bind(IVwPrm iVwPrm) {
            _sCamPrjArr = iVwPrm.SCamPrjArr;
            _iVwArr = iVwPrm.IVwArr;
        }

        public void Init() {
            // _iCurrVw = null;
        }

        public void SetCam(byte eVw, Camera cam) {
            _iVwArr[eVw].SetCam(cam);
        }

        public void SetCam(IVw iVw, Camera cam) {
            iVw.SetCam(cam);
        }

        public void SetCamPrj(byte eVw, byte eCamPrj) {
            _iVwArr[eVw].SetCamPrj(_sCamPrjArr[eCamPrj]);
        }

        public IVw Get(byte eVw) {
            return _iVwArr[eVw];
        }

        public void Enbl(byte eVw) {
            _iVwArr[eVw].Enbl();
        }

        public void Dsbl(byte eVw) {
            _iVwArr[eVw].Enbl();
        }

        public void Mv(byte eVw, byte eMv) {

        }
    }
}
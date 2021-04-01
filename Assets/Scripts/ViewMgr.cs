using System.Collections.Generic;
using UnityEngine;

namespace T {

    public class ViewMgr : Singleton<ViewMgr> {

        // private Camera _mainCam;
        private List<Camera> _camLis;
        private SCamProj[] _sCamProjArr;

        public void Bind(IViewPrime iViewPrime) {
            _sCamProjArr = iViewPrime.SCamProjArr;
        }

        public void Init() {
            // _camLis.Clear();
            _camLis = new List<Camera>();
            _camLis.Add(Camera.main);
            // _mainCam = Camera.main;
            
            // _iCamArr[(byte)ECam.Stg]
        }

        public void Create() {
            // new Camera();
        }

        public void Use(byte eCam) {
            // _iCamArr[eCam]
            // _mainCam
        }
    }
}
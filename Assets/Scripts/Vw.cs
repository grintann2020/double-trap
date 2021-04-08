using UnityEngine;

namespace T {

    public class Vw {
        
        protected Camera _cam;

        public void SetCam(Camera cam) {
            _cam = cam;
        }

        public void SetCamPrj(SCamPrj camPoj) {
            _cam.orthographic = camPoj.OP;
            _cam.orthographicSize = camPoj.OPSize;
            _cam.fieldOfView = camPoj.FOV;
            _cam.usePhysicalProperties = camPoj.PhyCam;
            _cam.nearClipPlane = camPoj.Near;
            _cam.farClipPlane = camPoj.Far;
        }

        public void Enbl() {
           _cam.enabled = true; 
        }

        public void Dsbl() {
           _cam.enabled = false; 
        }
    }
}
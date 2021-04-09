using UnityEngine;

namespace T {

    public class Vw {

        protected delegate void _dAct();
        protected Camera _cam;
        protected SOrntC3 _defOrnt;

        public void SetCam(Camera cam) {
            _cam = cam;
            _cam.transform.position = new Vector3(_defOrnt.A.X, _defOrnt.A.Y, _defOrnt.A.Z);
            _cam.transform.LookAt(new Vector3(_defOrnt.B.X, _defOrnt.B.Y, _defOrnt.B.Z));
        }

        public void SetCamPrj(SCamPrj camPoj) {
            _cam.orthographic = camPoj.OP;
            _cam.orthographicSize = camPoj.OPSize;
            _cam.fieldOfView = camPoj.FOV;
            _cam.usePhysicalProperties = camPoj.PhyCam;
            _cam.nearClipPlane = camPoj.Near;
            _cam.farClipPlane = camPoj.Far;
        }

        // public void Enbl() {
        //    _cam.enabled = true; 
        // }

        // public void Dsbl() {
        //    _cam.enabled = false; 
        // }
    }
}
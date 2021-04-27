using UnityEngine;

namespace T {

    public class Vw {

        protected delegate void _dChg();
        protected _dChg[] _dChgArr;
        protected Camera _cam;
        private SCamPrj _dflPrj;
        private SOrnt3 _dflOrnt;

        public Vw(SCamPrj dflPrj, SOrnt3 dflOrnt) {
            _dflPrj = dflPrj;
            _dflOrnt = dflOrnt;
        }

        public void Cam(Camera cam) {
            _cam = cam;
        }

        public void Prj(SCamPrj prj) {
            _cam.orthographic = prj.OP;
            _cam.orthographicSize = prj.OPSize;
            _cam.fieldOfView = prj.FOV;
            _cam.usePhysicalProperties = prj.PhyCam;
            _cam.nearClipPlane = prj.Near;
            _cam.farClipPlane = prj.Far;
        }

        public void Ornt(SOrnt3 ornt) {
            _cam.transform.position = new Vector3(ornt.A.X, ornt.A.Y, ornt.A.Z);
            _cam.transform.LookAt(new Vector3(ornt.B.X, ornt.B.Y, ornt.B.Z));
        }

        public void Dfl() {
            Prj(_dflPrj);
            Ornt(_dflOrnt);
        }

        public void Chg(byte eChg) {
            _dChgArr[eChg].Invoke();
        }
    }
}
using UnityEngine;

namespace T {

    public class Vw {

        protected delegate void _dMov();
        protected _dMov[] _dMovArr;
        protected Camera _cam;
        protected SCamPrj[] _prjArr;
        protected SOrnt3[] _orntArr;
        protected SCamPrj _dflPrj;
        protected SOrnt3 _dflOrnt;
        protected bool _isStup;

        // public Vw(SCamPrj dflPrj, SOrnt3 dflOrnt) {
        //     _dflPrj = dflPrj;
        //     _dflOrnt = dflOrnt;
        // }

        public Vw() {
            _cam = null;
        }

        public virtual void Stup(Camera cam) { // setup
            _cam = cam;
            Dfl();
            _isStup = true;
        }

        public virtual void Stdn() {
            _cam = null;
            _isStup = false;
        }

        public void Dfl() {
            Prj(_dflPrj);
            Ornt(_dflOrnt);
        }

        public void Prj(byte ePrj) {
            CamPrj(_prjArr[ePrj]);
        }

        public void Prj(SCamPrj prj) {
            CamPrj(prj);
        }

        public void Ornt(byte eOrnt) {
            CamOrnt(_orntArr[eOrnt]);
        }

        public void Ornt(SOrnt3 ornt) {
            CamOrnt(ornt);
        }

        public void Mov(byte eMov) {
            _dMovArr[eMov].Invoke();
        }

        public void InvkUpd() {
            if (_isStup == false) {
                return;
            }
        }

        private void CamPrj(SCamPrj prj) {
            _cam.orthographic = prj.OP;
            _cam.orthographicSize = prj.OPSize;
            _cam.fieldOfView = prj.FOV;
            _cam.usePhysicalProperties = prj.PhyCam;
            _cam.nearClipPlane = prj.Near;
            _cam.farClipPlane = prj.Far;
        }

        private void CamOrnt(SOrnt3 ornt) {
            _cam.transform.position = new Vector3(ornt.A.X, ornt.A.Y, ornt.A.Z);
            _cam.transform.LookAt(new Vector3(ornt.B.X, ornt.B.Y, ornt.B.Z));
        }
    }
}
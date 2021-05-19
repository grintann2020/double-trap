using UnityEngine;

namespace T {

    public class Vw {

        public bool IsStup { get { return _isStup; } }
        public bool IsMov { get { return _isMov; } }
        protected Camera _cam = null;
        protected SCamPrj[] _prjArr;
        protected SOrnt3[] _orntArr;
        protected ushort[] _stpArr;
        protected SCoord3[][][] _trkArr;
        protected byte[][] _movArr;
        protected SCamPrj _dflPrj;
        protected SOrnt3 _dflOrnt;
        private byte _eMov;
        private bool _isStup = false;
        private bool _isMov = false;

        public virtual void Stup(Camera cam) { // setup
            _isStup = true;
            _isMov = false;
            _eMov = 0;
            _cam = cam;
            Dfl();
        }

        public virtual void Stdn() { // setdown
            _isStup = false;
            _isMov = false;
            _eMov = 0;
            _cam = null;
            for (byte s = 0; s < _stpArr.Length; s++) {
                _stpArr[s] = 0;
            }
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

        public void Ornt(SCoord3 coordA, SCoord3 coordB) {
            _cam.transform.position = new Vector3(coordA.X, coordA.Y, coordA.Z);
            _cam.transform.LookAt(new Vector3(coordB.X, coordB.Y, coordB.Z));
        }

        public void Mov(byte eMov) {
            if (_isMov == true) {
                return;
            }
            _isMov = true;
            _eMov = eMov;
            _stpArr[_eMov] = 0;
        }

        public void InvkUpd() {
            if (_isStup == false || _isMov == false) {
                return;
            }
            Ornt(_trkArr[_eMov][_stpArr[_eMov]][0], _trkArr[_eMov][_stpArr[_eMov]][1]);
            _stpArr[_eMov] += 1;
            if (_stpArr[_eMov] == _trkArr[_eMov].Length) {
                _stpArr[_eMov] = 0;
                _isMov = false;
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
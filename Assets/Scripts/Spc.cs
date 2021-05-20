using System;

namespace T {

    public class Spc {

        public bool IsCnstr { get { return _isCnstr; } }
        public bool IsEstb { get { return _isEstb; } }
        public byte[][][] DflArr { get { return _dflArr; } }
        public byte[][][] CurArr { get { return _curArr; } }
        protected delegate void _dAlt();
        protected _dAlt[] _dAltArr;
        protected string[][] _uArr;
        protected byte[][][] _dflArr;
        protected byte[][][] _curArr;
        protected IBlk[][][] _iBlkArr;
        protected ISS _iSS;
        private bool _isCnstr = false;
        private bool _isEstb = false;

        public Spc(ISS iSS) {
            _iSS = iSS;
        }

        public void Cnstr(SCoord3 sCtr) {
            _isCnstr = true;
            _iBlkArr = _iSS.Cnstr(_curArr, sCtr);
        }

        public void Dcstr() {
            _isCnstr = false;
            Array.Clear(_iBlkArr, 0, _iBlkArr.Length);
        }

        public void Estb() {
            _isEstb = true;
            _iSS.Estb(_iBlkArr, _uArr);
        }

        public void Elim() {
            _isEstb = false;
            _iSS.Elim(_iBlkArr);
            // Debug.Log("Elim() -- ");
        }

        public void Dfl() {
            _curArr = _dflArr;
        }

        public void Alt(byte eAlt) {
            _dAltArr[eAlt].Invoke();
        }
    }
}
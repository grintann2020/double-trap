namespace T {

    public class Spc {

        public ushort DflRows { get { return (ushort)_dflArr.GetLength(0); } }
        public ushort DflCols { get { return (ushort)_dflArr.GetLength(1); } }
        public ushort DflLays { get { return (ushort)_dflArr.GetLength(2); } }
        public ushort CurRows { get { return (ushort)_curArr.GetLength(0); } }
        public ushort CurCols { get { return (ushort)_curArr.GetLength(1); } }
        public ushort CurLays { get { return (ushort)_curArr.GetLength(2); } }
        public ushort[][][] DflArr { get { return _dflArr; } }
        public ushort[][][] CurArr { get { return _curArr; } }
        protected delegate void _dAlt();
        protected _dAlt[] _dAltArr;
        protected ISS _iSS;
        protected ushort[][][] _dflArr;
        protected ushort[][][] _curArr;

        public Spc(ISS iSS) {
            _iSS = iSS;
        }
        
        public void Dfl() {
            _curArr = _dflArr;
        }

        public void Alt(byte eAlt) {
            _dAltArr[eAlt].Invoke();
        }
    }
}
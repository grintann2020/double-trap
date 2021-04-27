namespace T {

    public class Stg {

        // public ushort Rows { get { return (ushort)_objArr.GetLength(0); } }
        // public ushort Cols { get { return (ushort)_objArr.GetLength(1); } }
        // public bool[][] BoolArr { get { return _boolArr; } }
        // public ushort[][] ObjArr { get { return _objArr; } }
        protected ISpc _iSpc;
        // protected GameObject[]  
        protected IBlk[][] _iBlkArr;
        // protected bool[][] _defBoolArr, _boolArr;
        // protected ushort[][] _defObjArr, _objArr;
        

        public Stg(ISpc iSpc) {
            // Debug.Log("Stg -- Contructor( ) -- " + iSpc);
            _iSpc = iSpc;
        }

        // public void Def() {
            // _boolArr = _defBoolArr;
            // _objArr = _defObjArr;
        // }

        public void Constr() {
            // _iBlkArr = _iSpc.Abstr(_objArr);
        }

        public void Estb() {

        }

        public void Elim() {

        }
    }
}
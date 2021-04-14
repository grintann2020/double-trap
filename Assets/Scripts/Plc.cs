using UnityEngine;

namespace T {

    public class Plc {
        
        public ushort Rows { get { return (ushort)_boolArr.GetLength(0); } }
        public ushort Cols { get { return (ushort)_boolArr.GetLength(1); } }
        protected ISpc _iSpc;
        protected IBlk[][] _iBlkArr;
        protected bool[][] _defBoolArr, _boolArr;
        protected ushort[][] _defObjArr, _objArr;
        
        public Plc(ISpc iSpc) {
            Debug.Log("Plc -- Contructor( ) -- " + iSpc);
            _iSpc = iSpc;
        }

        public void SetDef() {
            _boolArr = _defBoolArr;
            _objArr = _defObjArr;
        }

        public void Constr() {
            _iBlkArr = _iSpc.Abstr(_objArr);

        }

        public void Estb() {

        }

        public void Elim() {

        }
    }
}
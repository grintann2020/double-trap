using T;

namespace DT {

    public class ATut1Plc : Plc, IPlc {

        private const ushort DEF_ROWS = 4;
        private const ushort DEF_COLS = 4;

        public ATut1Plc(ISpc iSpc) : base(iSpc) {
            _defBoolArr = new bool[DEF_ROWS][];
            _defBoolArr[0] = new bool[DEF_COLS] { true, true, true, true };
            _defBoolArr[1] = new bool[DEF_COLS] { true, true, true, true };
            _defBoolArr[2] = new bool[DEF_COLS] { true, true, true, true };
            _defBoolArr[3] = new bool[DEF_COLS] { true, true, true, true };
            _boolArr = _defBoolArr;

            _defObjArr = new ushort[DEF_ROWS][];
            _defObjArr[0] = new ushort[DEF_COLS] { 1, 1, 1, 1 };
            _defObjArr[1] = new ushort[DEF_COLS] { 1, 1, 1, 1 };
            _defObjArr[2] = new ushort[DEF_COLS] { 1, 1, 1, 1 };
            _defObjArr[3] = new ushort[DEF_COLS] { 1, 1, 1, 1 };
            _objArr = _defObjArr;
        }
    }
}
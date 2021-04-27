using System;
using T;

namespace DT {

    public enum EStg : byte {
        ATut0, ATut1, A2, A3, A04, A05, A06, A07, A08, A09, A10,
        A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21,
        B00, B01, B02, B03, B04, B05, B06, B07, B08, B09, B10,
        B11, B12, B13, B14, B15, B16, B17, B18, B19, B20, B21,
        XHex
    }

    public class StgPrm : IStgPrm {

        public IStg[] IStgArr { get { return _iStgArr; } }
        private IStg[] _iStgArr = new IStg[Enum.GetNames(typeof(EStg)).Length];
        private ISpc _iSquSpc;
        private ISpc _iHexSpc;

        public StgPrm() {
            _iSquSpc = new SquSpc(1, 1);
            _iHexSpc = new HexSpc(1, 2); // For Test
            _iStgArr[(byte)EStg.ATut0] = new ATut0Stg(_iSquSpc);
            _iStgArr[(byte)EStg.ATut1] = new ATut1Stg(_iSquSpc);
            _iStgArr[(byte)EStg.XHex] = new XHexStg(_iHexSpc);
        }
    }
}
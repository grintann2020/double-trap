using System;
using T;

namespace DT {

    public enum EPlc : byte {
        ATut0, ATut1, XHex1
    }

    public class PlcPrm : IPlcPrm { // place prime

        public IPlc[] IPlcArr { get { return _iPlcArr; } }
        private IPlc[] _iPlcArr = new IPlc[Enum.GetNames(typeof(EPlc)).Length];
        private ISpc _iSquSpc;
        private ISpc _iHexSpc;

        public PlcPrm() {
            _iSquSpc = new SquSpc(new SquCalc(), 1);
            _iHexSpc = new HexSpc(new HexCalc(), 1); // For Test
            _iPlcArr[(byte)EPlc.ATut0] = new ATut0Plc(_iSquSpc);
            _iPlcArr[(byte)EPlc.ATut1] = new ATut1Plc(_iSquSpc);
            _iPlcArr[(byte)EPlc.XHex1] = new XHex1Plc(_iHexSpc); // For Test
        }
    }
}
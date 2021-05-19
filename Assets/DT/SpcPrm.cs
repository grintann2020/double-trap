using System;
using T;

namespace DT {

    public enum ESS : byte {
        Squ, Hex
    }

    public enum ESpc : byte {
        A0, A1, B0, B1
    }

    public class SpcPrm : ISpcPrm { // the prime of spatial structure

        public ISpc[] ISpcArr { get { return _iSpcArr; } }
        private ISpc[] _iSpcArr = new ISpc[Enum.GetNames(typeof(ESpc)).Length];
        private ISS[] _iSSArr = new ISS[Enum.GetNames(typeof(ESS)).Length];
        private ISS _iSquSS;
        private ISS _iHexSS;

        public SpcPrm() {
            _iSSArr[(byte)ESS.Squ] = new SquSS(1, 1);
            _iSSArr[(byte)ESS.Hex] = new HexSS(1, 2); // For Test
            _iSpcArr[(byte)ESpc.A0] = new A0Spc(_iSquSS);
            _iSpcArr[(byte)ESpc.A1] = new A1Spc(_iSquSS);
            _iSpcArr[(byte)ESpc.B0] = new B0Spc(_iHexSS);
        }
    }
}
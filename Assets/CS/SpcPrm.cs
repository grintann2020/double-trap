using System;
using T;

namespace CS {

    public enum ESpc : byte {
        Spc1, Spc2
    }

    public class SpcPrm : ISpcPrm { // place prime

        public ISpc[] ISpcArr { get { return _iSpcArr; } }
        private ISpc[] _iSpcArr = new ISpc[Enum.GetNames(typeof(ESpc)).Length];


        public SpcPrm() {

        }
    }
}
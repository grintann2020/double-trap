using System;
using UnityEngine;
using T;

namespace DT {

    public enum ESpc : byte {
        Spc00, Spc01
    }

    public class SpcPrm : ISpcPrm {
        
        public ISpc[] ISpcArr { get { return _iSpcArr; } }
        private ISpc[] _iSpcArr = new ISpc[Enum.GetNames(typeof(ESpc)).Length];

        public SpcPrm() {

        }
    }
}
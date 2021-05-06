using System;
using UnityEngine;
using T;

namespace DT {

    public enum EIa : byte {
        A0, A1
    }

    public class IaPrm : IIaPrm {
        
        public IIa[] IIaArr { get { return _iIaArr; } }
        private IIa[] _iIaArr = new IIa[Enum.GetNames(typeof(EIa)).Length];

        public IaPrm() {
            _iIaArr[(byte)EIa.A0] = new A0Ia();
            _iIaArr[(byte)EIa.A1] = new A1Ia();
        }
    }
}
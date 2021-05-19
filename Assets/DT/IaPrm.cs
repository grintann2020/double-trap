using System;
using UnityEngine;
using T;

namespace DT {

    public enum EII : byte {
        Mus, KB
    }

    public enum EIa : byte {
        A0, A1
    }

    public class IaPrm : IIaPrm {

        public IIa[] IIaArr { get { return _iIaArr; } }
        private IIa[] _iIaArr = new IIa[Enum.GetNames(typeof(EIa)).Length];
        private III[] _iIIArr = new III[Enum.GetNames(typeof(EII)).Length];

        public IaPrm() {
            _iIIArr[(byte)EII.Mus] = new MusII();
            _iIIArr[(byte)EII.KB] = new KBII();
            _iIaArr[(byte)EIa.A0] = new A0Ia(_iIIArr);
            _iIaArr[(byte)EIa.A1] = new A1Ia(_iIIArr);
        }
    }
}
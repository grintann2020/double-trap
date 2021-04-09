using System;
using UnityEngine;
using T;

namespace DT {

    public enum EIa : byte {
        TestIa
    }

    public class IaPrm : IIaPrm {
        
        public IIa[] IIaArr { get { return _iIaArr; } }
        private IIa[] _iIaArr = new IIa[Enum.GetNames(typeof(EIa)).Length];

        // private MenuVw _menuVw = new MenuVw();

        public IaPrm() {
            // _iVwArr[(byte)EVw.Menu] = _menuVw;
        }
    }
}
using System;
using UnityEngine;
using T;

namespace DT {

    public enum EUI : byte {
        Menu
    }

    public class UIPrm : IUIPrm {
        
        public IUI[] IUIArr { get { return _iUIArr; } }
        private IUI[] _iUIArr = new IUI[Enum.GetNames(typeof(EUI)).Length];

        public UIPrm() {

        }
    }
}
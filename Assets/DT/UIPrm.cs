using System;
using T;

namespace DT {

    public enum EUI : byte {
        UI1, UI2, UI3
    }

    public enum EUIElem : byte {
        UIElem1, UIElem2, UIElem3, UIElem4, UIElem5, 
        UIElem16, UIElem7, UIElem8, UIElem9, UIElem10, 
    }

    public class UIPrm : IUIPrm {
        
        public IUI[] IUIArr { get { return _iUIArr; } }
        private IUI[] _iUIArr = new IUI[Enum.GetNames(typeof(EUI)).Length];

        public UIPrm() {
            // _iUIArr[(byte)EUI.UI1] = 
        }
    }
}
using System;
using T;

namespace CS {

    public enum EUI : byte {
        Splh, Fst,
    }

    public class UIPrm : IUIPrm {
        
        public IUI[] IUIArr { get { return _iUIArr; } }
        private IUI[] _iUIArr = new IUI[Enum.GetNames(typeof(EUI)).Length];

        public UIPrm() {

        }
    }
}
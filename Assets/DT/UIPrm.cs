using System;
using T;

namespace DT {

    public enum EUI : byte {
        Splh, Fst,
    }

    public class UIPrm : IUIPrm {
        
        public IUI[] IUIArr { get { return _iUIArr; } }
        private IUI[] _iUIArr = new IUI[Enum.GetNames(typeof(EUI)).Length];

        public UIPrm() {
            _iUIArr[(byte)EUI.Splh] = new SplhUI();
            _iUIArr[(byte)EUI.Fst] = new FstUI();
        }
    }
}
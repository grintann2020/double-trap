using System;
using UnityEngine;
using T;

namespace CS {

    public enum ETerm : ushort {
        GrinBit,
        DoubleTrap,
    }

    public class LangPrm : ILangPrm {

        public ELang[] LangArr { get { return _langArr; } }
        public string[][] TermArr { get { return _termArr; } }
        private ELang[] _langArr = new ELang[] {
            ELang.EN,
            ELang.ZH_TW,
        };
        private string[][] _termArr = new string[Enum.GetNames(typeof(ETerm)).Length][];

        public LangPrm() {
            _termArr[(byte)ETerm.GrinBit] = new string[] { "Grin Bit", "Grin Bit" };
            _termArr[(byte)ETerm.DoubleTrap] = new string[] { "DoubleTrap", "雙重陷阱" };
        }
    }
}
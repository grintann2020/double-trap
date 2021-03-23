using System.Collections.Generic;
using UnityEngine;
using T;

namespace DT {

    public enum ETerm : ushort {
        GrinBit,
        DoubleTrap,
        Test
    }

    public class LangPrime : ILangPrime {

        public LangMgr Mgr { private get; set; }
        public string Term (ushort term, ushort lang) {
            return (string)_sheet[term, lang];
        }
        private static object[,] _sheet = new object[,] {
            {ETerm.GrinBit, "Grin Bit", "Grin Bit"},
            {ETerm.DoubleTrap, "Double Trap", "雙重陷阱"},
            {ETerm.Test, "Test", "測試"}
        };

        public void Init() {

        }
    }
}
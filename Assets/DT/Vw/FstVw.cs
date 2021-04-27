using System;
using UnityEngine;
using T;

namespace DT {

    public class FstVw : Vw, IVw {

        public enum EChg {
            Test, GG, ok
        }

        public FstVw(SCamPrj dflProj, SOrnt3 dflOrnt) : base(dflProj, dflOrnt) {
            _dChgArr = new _dChg[Enum.GetNames(typeof(EChg)).Length];
            _dChgArr[(byte)EChg.Test] = Test;
            _dChgArr[(byte)EChg.GG] = GG;
        }

        public void InvkUpd() {

        }

        public void Test() {
            Debug.Log("FstVw -- Test()");
        }

        public void GG() {
            Debug.Log("FstVw -- GG()");
        }
    }
}
using UnityEngine;
using T;

namespace DT {

    public class StgPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            // Debug.Log("StgPgm InvkUpd()");
        }

        public void Exe() {
            StgMgr.Ins.Imp((byte)EStg.ATut0);
            Debug.Log("StgPgm Exe()");
        }

        public void End() {

        }
    }
}
using UnityEngine;
using T;

namespace DT {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvokeUpd() {

        }

        public void Exe() {
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            StgMgr.Ins.Init();
            
            Debug.Log("DT) init program --> executed");

            PgmMgr.Ins.Next();
        }

        public void End() {
            Debug.Log("DT) init program --> end");
        }
    }
}
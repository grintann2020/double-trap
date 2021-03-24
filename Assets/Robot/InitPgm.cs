using UnityEngine;
using T;

namespace Robot {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvokeUpd() {

        }

        public void Exe() {
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            StgMgr.Ins.Init();
            
            Debug.Log("Robot) init program --> executed");

            PgmMgr.Ins.Next();
        }

        public void End() {
            Debug.Log("Robot) init program --> end");
        }
    }
}
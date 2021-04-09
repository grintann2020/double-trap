using UnityEngine;
using T;

namespace CS {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {

        }

        public void Exe() {
            UIMgr.Ins.Init();
            IaMgr.Ins.Init();
            StgMgr.Ins.Init();
            
            Debug.Log("Robot) init program --> executed");

            PgmMgr.Ins.Next();
        }

        public void End() {
            Debug.Log("Robot) init program --> end");
        }
    }
}
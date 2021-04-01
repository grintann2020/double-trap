using UnityEngine;
using T;

namespace DT {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvokeUpd() {

        }

        public void Exe() {
            LangMgr.Ins.Init();
            ViewMgr.Ins.Init();
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            StgMgr.Ins.Init();

            ViewMgr.Ins.Create();
            
            Debug.Log("DT) init program --> executed");
            Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Four));

            PgmMgr.Ins.Next();
        }

        public void End() {
            Debug.Log("DT) init program --> end");
        }
    }
}
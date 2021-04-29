using T;

namespace DT {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            // Debug.Log("InitPgm -- InvkUpd()");
        }

        public void Exe() {
            LangMgr.Ins.Init();
            ResMgr.Ins.Init();
            VwMgr.Ins.Init();
            UIMgr.Ins.Init();
            IaMgr.Ins.Init();
            StgMgr.Ins.Init();
            SpcMgr.Ins.Init();
            PgmMgr.Ins.Next();
        }

        public void End() {
            // Debug.Log("DT) init program --> end");
        }
    }
}
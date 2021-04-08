using UnityEngine;
using T;

namespace DT {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {

        }

        public void Exe() {
            
            LangMgr.Ins.Init();
            VwMgr.Ins.Init();
            UIMgr.Ins.Init();
            InteractMgr.Ins.Init();
            StgMgr.Ins.Init();

            VwMgr.Ins.SetCam((byte)EVw.Menu, Camera.main);

            // Debug.Log("DT) init program --> executed");
            // LangMgr.Ins.Chg(ELang.ZH_CN);
            Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // LangMgr.Ins.Change((byte)ELang.EN_US);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // LangMgr.Ins.Change(SystemLanguage.ChineseTraditional);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // VwMgr.Ins.Set((byte)EVw.Menu);

            PgmMgr.Ins.Next();
        }

        public void End() {
            // Debug.Log("DT) init program --> end");
        }
    }
}
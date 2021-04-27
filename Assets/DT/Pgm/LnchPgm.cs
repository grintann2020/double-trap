using System.Collections;
using UnityEngine;
using T;

namespace DT {

    public class TestPgm : SgltnMB<TestPgm> {

        public void TestWait(int sec, GameObject[] goArr = null) {
            if (goArr == null) {
                StartCoroutine(TestW(sec));
            } else {
                StartCoroutine(TestW(sec, goArr));
            }
        }

        IEnumerator TestW(int sec, GameObject[] goArr = null) {
            yield return new WaitForSeconds(sec);
            // UIMgr.Ins.Unstl((byte)EUI.Splh);
            // UIMgr.Ins.Unstl((byte)EUI.Fst);
            // UIMgr.Ins.Dsbl((byte)EUI.Splh, (byte)SplhUI.ESet.A1);
            // UIMgr.Ins.DsblElem((byte)EUI.Splh, (byte)SplhUI.EElem.BtnB2);
            // UIMgr.Ins.DsblSet((byte)EUI.Splh, (byte)SplhUI.ESet.A1);
            yield return new WaitForSeconds(sec);
            // UIMgr.Ins.Instl((byte)EUI.Splh);
            // UIMgr.Ins.Enbl((byte)EUI.Splh, (byte)SplhUI.ESet.A1);
            // UIMgr.Ins.EnblElem((byte)EUI.Splh, (byte)SplhUI.EElem.BtnB2);
            // UIMgr.Ins.EnblSet((byte)EUI.Splh, (byte)SplhUI.ESet.A1);
        }
    }

    public class LnchPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            // Debug.Log("LnchPgmPgm -- InvkUpd()");
            UIMgr.Ins.InvkUpd();
        }

        public void Exe() {
            // Debug.Log("LnchPgmPgm -- Exe()");
            VwMgr.Ins.Cam((byte)EVw.Menu, Camera.main);
            VwMgr.Ins.Prj((byte)EVw.Menu, (byte)ECamPrj.Menu);
            UIMgr.Ins.SetCanv((byte)EUI.Splh, GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>());
            UIMgr.Ins.SetCanv((byte)EUI.Fst, GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>());
            UIMgr.Ins.Instl((byte)EUI.Splh);
            UIMgr.Ins.Instl((byte)EUI.Fst);
            TestPgm.Ins.TestWait(2);

            // test LangMgr
            LangMgr.Ins.Chg(ELang.ZH_CN);
            // LangMgr.Ins.Chg((byte)ELang.EN_US);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Three_U));
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U, ELang.EN));

            // LangMgr.Ins.Chg(SystemLanguage.ChineseTraditional);
            // Debug.Log(LangMgr.Ins.Term((ushort)ETerm.Six_U));

            // test VwMgr
            // VwMgr.Ins.Act((byte)EVw.Menu, (byte)MenuVw.EAct.Test);
            VwMgr.Ins.Chg((byte)EVw.Menu, (byte)FstVw.EChg.GG);
            // VwMgr.Ins.Act((byte)EVw.Play, (byte)PlayVw.EAct.P1);
            // VwMgr.Ins.Act((byte)EVw.Play, (byte)PlayVw.EAct.P2);

            // Debug.Log("DT) init program --> executed");
        }

        public void End() {

        }
    }
}
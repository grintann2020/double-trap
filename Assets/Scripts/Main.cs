using UnityEngine;

// For Test
using UnityEngine.UI;
using DT;

namespace T {

    public class Main : SingletonMB<Main> {

        [SerializeField] private Settings _settings;

        // For Test
        public Text TestTxt;

        private void Awake() {
            Debug.Log(GameMgr.Ins);
            GameMgr.Ins.Bind(_settings);
        }

        private void Start() {
            GameMgr.Ins.Init();

            // For Test
            TestTxt.text = LangMgr.Ins.Term((ushort)ETerm.Three_U);
            // LangMgr.Ins.Change(ELang.ZH_CN);
            // TestTxt.text = LangMgr.Ins.TermArr[(ushort)ETerm.Three_U][(byte)LangMgr.Ins.ECurrLang];
        }

        private void Update() {
            GameMgr.Ins.InvkUpd();
        }

        // For Test
        public void ChangeTesText(int eLang) {
            LangMgr.Ins.Chg((byte)eLang);
        }

        public void ShowText(int eTerm) {
            Debug.Log(LangMgr.Ins.Term((ushort)eTerm) +", test "+ LangMgr.Ins.Term((ushort)eTerm, ELang.ZH_TW));
        }
    }
}
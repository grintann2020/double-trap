using UnityEngine;

namespace T {

    public class GameMgr : Singleton<GameMgr> {

        private Settings _settings;
        // private ScrRezSO[] _scrRezArr;
        // private ScrRezSO _currScrRez;
        private ScrRez _scrRez;
        private PgmMgr _pgmMgr;

        public void Bind(Settings settings) {
            _settings = settings;
        }

        public void Init() {
            _scrRez = _settings.ScrRez;
            // ScrRez(_scrRezArr[3]);
            PgmMgr.Ins.Init();
            PgmMgr.Ins.ExePgm(EPgm.Init);

            // _scrRez.DecideAR();
            // Debug.Log("AR --> " + _scrRez.AR);
            Debug.Log("AR --> " + _scrRez.AR+ ", Wd --> " + _scrRez.Wd + ", Ht --> " + _scrRez.Ht);
            // Debug.Log("AR --> " + (float)Screen.height / (float)Screen.width + ", Wd --> " + Screen.width + ", Ht --> " + Screen.height);
        }

        public void InvokeUpd() {
            PgmMgr.Ins.InvokeUpd();
        }

        public void ScrRez(ScrRez scrRez) {
            // Screen.SetResolution(scrRez.Wd, scrRez.Ht, true);
            // _currScrRez = scrRez;
        }

        public void ScrRez(int wd, int ht) {
            Screen.SetResolution(wd, ht, true);
        }
    }
}
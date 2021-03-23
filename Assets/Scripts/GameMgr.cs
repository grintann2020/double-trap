using UnityEngine;
using T;

namespace T {

    public class GameMgr : Singleton<GameMgr> {

        private Settings _settings;
        private ScrRez _scrRez;

        public void Bind(Settings settings) {
            _settings = settings;
            _scrRez = settings.ScrRez;
            PgmMgr.Ins.Bind(_settings.IPrime.IPgmPrime);
            // PgmMgr.Ins.Bind(_settings.IPgmGrp);
        }

        public void Begin() {
            Setting();
            PgmMgr.Ins.Init();
        }

        public void Setting() {
            SetRez(2);
        }

        public void InvokeUpd() {
            PgmMgr.Ins.InvokeUpd();
        }

        public void SetRez() {
            Screen.SetResolution(_scrRez.Wd, _scrRez.Ht, true);
            Debug.Log("Screen Resolution --> Width: " + _scrRez.Wd + ", Height: " + _scrRez.Ht + ", aspect ratio: " + _scrRez.AR);
        }

        public void SetRez(byte lv) {
            if (lv > _scrRez.NumOfLv) {
                lv = _scrRez.NumOfLv;
            }
            _scrRez.Lv = lv;
            Screen.SetResolution(_scrRez.Wd, _scrRez.Ht, true);
            Debug.Log("Screen Resolution --> Width: " + _scrRez.Wd + ", Height: " + _scrRez.Ht + ", aspect ratio: " + _scrRez.AR);
        }
    }
}
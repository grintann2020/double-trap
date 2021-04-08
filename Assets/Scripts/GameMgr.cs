using UnityEngine;

namespace T {

    public class GameMgr : Singleton<GameMgr> {

        private Settings _settings;
        private ScrRez _scrRez;

        public void Bind(Settings settings) {
            _settings = settings;
            _scrRez = _settings.ScrRez;
            PrmMgr.Ins.Bind(_settings.EGame);
        }

        public void Init() {
            Setting();
            PgmMgr.Ins.Init();
            PgmMgr.Ins.Exe(0);
        }

        public void Setting() {
            SetRez(2);
        }

        public void InvkUpd() {
            PgmMgr.Ins.InvkUpd();
        }

        public void SetRez() {
            Screen.SetResolution(_scrRez.Wd, _scrRez.Ht, true);
            // Debug.Log("Screen Resolution --> Width: " + _scrRez.Wd + ", Height: " + _scrRez.Ht + ", aspect ratio: " + _scrRez.AR);
        }

        public void SetRez(byte lv) {
            if (lv > _scrRez.NumOfLv) {
                lv = _scrRez.NumOfLv;
            }
            _scrRez.Lv = lv;
            Screen.SetResolution(_scrRez.Wd, _scrRez.Ht, true);
            // Debug.Log("Screen Resolution --> Width: " + _scrRez.Wd + ", Height: " + _scrRez.Ht + ", aspect ratio: " + _scrRez.AR);
        }
    }
}
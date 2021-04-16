using UnityEngine;

namespace T {

    public class Main : SingletonMB<Main> {

        [SerializeField] private Settings _settings;

        private void Awake() {
            Debug.Log(GameMgr.Ins);
            GameMgr.Ins.Bind(_settings);
        }

        private void Start() {
            GameMgr.Ins.Init();
        }

        private void Update() {
            GameMgr.Ins.InvkUpd();
        }
    }
}
using UnityEngine;

namespace T {

    public class Main : SingletonMB<Main> {

        [SerializeField] private Settings _settings;

        void Awake() {
            Debug.Log(GameMgr.Ins);
            GameMgr.Ins.Bind(_settings);
        }

        void Start() {
            GameMgr.Ins.Init();
        }

        void Update() {
            GameMgr.Ins.InvokeUpd();
        }
    }
}
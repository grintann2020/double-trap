using UnityEngine;

namespace T {

    public class Main : MonoBehaviour {

        void Awake() {
            Debug.Log(PgmMgr.Ins);
        }

        void Start() {
            PgmMgr.Ins.Init();
            PgmMgr.Ins.ExePgm(EPgm.Init);
        }

        void Update() {
            PgmMgr.Ins.InvokeUpd();
        }
    }
}
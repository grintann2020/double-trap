using System;

namespace T {

    public class PrmMgr : Singleton<PrmMgr> {

        private IPrm[] _iPrmArr = new IPrm[Enum.GetNames(typeof(EGame)).Length];

        public PrmMgr() {
            _iPrmArr[(byte)EGame.DT] = new DT.Prm();
            _iPrmArr[(byte)EGame.CS] = new CS.Prm();
        }

        public void Bind(EGame eGame) {
            _iPrmArr[(byte)eGame].Bind();
        }
    }
}
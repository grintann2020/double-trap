using System;

namespace T {

    public class PrmMgr : Sgltn<PrmMgr> {

        private IPrm[] _iPrmArr = new IPrm[Enum.GetNames(typeof(EGame)).Length];

        public PrmMgr() {
            // here has already checked, the new operate script will not execute unless Prim.Bind()
            _iPrmArr[(byte)EGame.DT] = new DT.Prm();
            _iPrmArr[(byte)EGame.CS] = new CS.Prm();
        }

        public void Bind(EGame eGame) {
            _iPrmArr[(byte)eGame].Bind();
        }
    }
}
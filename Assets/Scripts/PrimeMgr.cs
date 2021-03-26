using System;

namespace T {

    public class PrimeMgr : Singleton<PrimeMgr> {

        private IPrime[] _iPrimeArr = new IPrime[Enum.GetNames(typeof(EGame)).Length];

        public PrimeMgr() {
            _iPrimeArr[(byte)EGame.DT] = new DT.Prime();
            _iPrimeArr[(byte)EGame.Robot] = new Robot.Prime();
        }

        public void Bind(EGame eGame) {
            _iPrimeArr[(byte)eGame].Bind();
        }
    }
}
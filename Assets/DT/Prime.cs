using T;

namespace DT {

    public class Prime : IPrime {

        public IPgmPrime IPgmPrime { get { return new PgmPrime(); } }
        public ILangPrime ILangPrime { get { return new LangPrime(); } }

        public void Bind() {
            PgmMgr.Ins.Bind(IPgmPrime);
            LangMgr.Ins.Bind(ILangPrime);
        }
    } 
}
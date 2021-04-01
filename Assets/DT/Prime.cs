using T;

namespace DT {

    public class Prime : IPrime {

        public IPgmPrime IPgmPrime { get { return new PgmPrime(); } }
        public ILangPrime ILangPrime { get { return new LangPrime(); } }
        public IViewPrime IViewPrime { get { return new ViewPrime(); } }

        public void Bind() {
            PgmMgr.Ins.Bind(IPgmPrime);
            LangMgr.Ins.Bind(ILangPrime);
            ViewMgr.Ins.Bind(IViewPrime);
        }
    } 
}
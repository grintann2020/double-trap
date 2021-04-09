using T;

namespace DT {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }
        public IVwPrm IVwPrm { get { return new VwPrm(); } }
        public IIaPrm IIaPrm { get { return new IaPrm(); } }
        public ISpcPrm ISpcPrm { get { return new SpcPrm(); } }
        public IStgPrm IStgPrm { get { return new StgPrm(); } }

        public void Bind() {
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
            VwMgr.Ins.Bind(IVwPrm);
            IaMgr.Ins.Bind(IIaPrm);
            SpcMgr.Ins.Bind(ISpcPrm);
            StgMgr.Ins.Bind(IStgPrm);
        }
    } 
}
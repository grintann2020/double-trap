using UnityEngine;
using T;

namespace CS {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }
        public ISpcPrm ISpcPrm { get { return new SpcPrm(); } }
        public IVwPrm IVwPrm { get { return new VwPrm(); } }
        public IIaPrm IIaPrm { get { return new IaPrm(); } }
        public IUIPrm IUIPrm { get {return new UIPrm();} }

        public void Bind() {
            Debug.Log("CS -- Prm -- Bind()");
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
        }
    }
}
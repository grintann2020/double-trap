using UnityEngine;
using T;

namespace DT {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }
        // public IResPrm IResPrm { get { return new ResPrm(); } }
        public ISpcPrm ISpcPrm { get { return new SpcPrm(); } }
        public IVwPrm IVwPrm { get { return new VwPrm(); } }
        public IIaPrm IIaPrm { get { return new IaPrm(); } }
        public IStgPrm IStgPrm { get { return new StgPrm(); } }
        public IUIPrm IUIPrm { get { return new UIPrm(); } }
        public IHubPrm IHubPrm { get { return new HubPrm(); } }

        public void Bind() {
            // Debug.Log("DT -- Prm -- Bind()");
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
            // ResMgr.Ins.Bind(IResPrm);
            VwMgr.Ins.Bind(IVwPrm);
            IaMgr.Ins.Bind(IIaPrm);
            SpcMgr.Ins.Bind(ISpcPrm);
            StgMgr.Ins.Bind(IStgPrm);
            UIMgr.Ins.Bind(IUIPrm);
            HubMgr.Ins.Bind(IHubPrm);
        }
    } 
}
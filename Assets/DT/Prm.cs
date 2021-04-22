using UnityEngine;
using T;

namespace DT {

    public class Prm : IPrm {

        public IPgmPrm IPgmPrm { get { return new PgmPrm(); } }
        public ILangPrm ILangPrm { get { return new LangPrm(); } }
        public IResPrm IResPrm { get { return new ResPrm(); } }
        public IPlcPrm IPlcPrm { get { return new PlcPrm(); } }
        public IVwPrm IVwPrm { get { return new VwPrm(); } }
        public IIaPrm IIaPrm { get { return new IaPrm(); } }
        public IStgPrm IStgPrm { get { return new StgPrm(); } }
        public IUIPrm IUIPrm { get { return new UIPrm(); } }

        public void Bind() {
            // Debug.Log("DT -- Prm -- Bind()");
            PgmMgr.Ins.Bind(IPgmPrm);
            LangMgr.Ins.Bind(ILangPrm);
            ResMgr.Ins.Bind(IResPrm);
            VwMgr.Ins.Bind(IVwPrm);
            IaMgr.Ins.Bind(IIaPrm);
            PlcMgr.Ins.Bind(IPlcPrm);
            StgMgr.Ins.Bind(IStgPrm);
            UIMgr.Ins.Bind(IUIPrm);
        }
    } 
}
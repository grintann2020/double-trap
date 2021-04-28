namespace T {

    public interface IPrm {

        IPgmPrm IPgmPrm { get; }
        // IResPrm IResPrm { get; }
        ILangPrm ILangPrm { get; }
        IVwPrm IVwPrm { get; }
        IIaPrm IIaPrm { get; }
        ISpcPrm ISpcPrm { get; }
        void Bind();
    }
}
namespace T {

    public interface IPrm {

        IPgmPrm IPgmPrm { get; }
        ILangPrm ILangPrm { get; }
        IVwPrm IVwPrm { get; }
        IIaPrm IIaPrm { get; }
        void Bind();
    }
}
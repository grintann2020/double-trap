namespace T {

    public interface ILangPrime {

        LangMgr Mgr { set; }
        string Term(ushort term, ushort lang);
        void Init();
    }
}

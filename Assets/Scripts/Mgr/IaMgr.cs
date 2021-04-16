namespace T {

    public class IaMgr : Singleton<IaMgr> {

        private IIa[] _iIaArr;

        public void Bind(IIaPrm iIaPrm) {
            _iIaArr = iIaPrm.IIaArr;
        }

        public void Init() {

        }
    }
}
namespace T {

    public class IaMgr : Sgltn<IaMgr> {

        private IIa[] _iIaArr;

        public void Bind(IIaPrm iIaPrm) {
            _iIaArr = iIaPrm.IIaArr;
        }

        public void Init() {

        }
    }
}
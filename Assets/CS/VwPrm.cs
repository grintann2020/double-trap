using System;
using T;

namespace CS {

    public enum ECamPrj : byte {
        Test
    }

    public enum EVwOrnt : byte {
        Test0, Test1,
    }

    public enum EVw : byte {
        Test
    }

    public class VwPrm : IVwPrm {
        
        public SCamPrj[] SPrjArr { get { return _sPrjArr; } }
        public SOrnt3[] SOrntArr { get { return _sOrntArr; } }
        public IVw[] IVwArr { get { return _iVwArr; } }
        private SCamPrj[] _sPrjArr = new SCamPrj[Enum.GetNames(typeof(ECamPrj)).Length];
        private SOrnt3[] _sOrntArr = new SOrnt3[Enum.GetNames(typeof(EVwOrnt)).Length];
        private IVw[] _iVwArr = new IVw[Enum.GetNames(typeof(EVw)).Length];
        
        public VwPrm() {

        }
    }
}
using System;
using UnityEngine;
using T;

namespace CS {

    public enum ECamPrj : byte {
        Test
    }

    public enum EVw : byte {
        Test
    }

    public class VwPrm : IVwPrm {
        
        public SCamPrj[] SCamPrjArr { get { return _sCamPrjArr; } }
        public IVw[] IVwArr { get { return _iVwArr; } }

        private SCamPrj[] _sCamPrjArr = new SCamPrj[Enum.GetNames(typeof(ECamPrj)).Length];
        private IVw[] _iVwArr = new IVw[Enum.GetNames(typeof(EVw)).Length];
        
        public VwPrm() {

        }
    }
}
using System;
using UnityEngine.AddressableAssets;
using UnityEngine;
using T;

namespace CS {

    public enum ERes : ushort {
        CubeRed, SphereRed, CylinderRed,
        Red, Green, Blue,
    }

    public class XXXResPrm : XXXIResPrm {

        public object[][] ResArr { get { return _resArr; } }
        private object[][] _resArr = new object[Enum.GetNames(typeof(ERes)).Length][];

        public XXXResPrm() {

        }
    }
}
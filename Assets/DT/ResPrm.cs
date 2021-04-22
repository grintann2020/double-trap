using System;
using T;

namespace DT {

    public enum EResLbl : byte {
        UI, SplhUI, test1, test2, test3
    }

    public enum ERes : ushort {
        CubeRed, SphereRed, CylinderRed,
        SplhUIA1, SplhUIA2,
        Red, Green, Blue,
        BoxRed, BoxGreen, BoxBlue, BoxBlack, BoxWhite,
    }

    public class ResPrm : IResPrm {

        public object[][] ResArr { get { return _resArr; } }
        private object[][] _resArr = new object[Enum.GetNames(typeof(ERes)).Length][];

        public ResPrm() {
            _resArr[(ushort)ERes.SplhUIA1] = new object[] { "SplhUIA1", null };
            _resArr[(ushort)ERes.SplhUIA2] = new object[] { "SplhUIA2", null };
            _resArr[(ushort)ERes.CubeRed] = new object[] { "CubeRed", null };
            _resArr[(ushort)ERes.SphereRed] = new object[] { "SphereRed", null };
            _resArr[(ushort)ERes.CylinderRed] = new object[] { "CylinderRed", null };
            
            // _resArr[(ushort)ERes.Red] = new object[] { "Red" };
            // _resArr[(ushort)ERes.Green] = new object[] { "Green" };
            // _resArr[(ushort)ERes.Blue] = new object[] { "Blue" };
            // _resArr[(ushort)ERes.BoxRed] = new object[] { "BoxRed" };
            // _resArr[(ushort)ERes.BoxGreen] = new object[] { "BoxGreen" };
            // _resArr[(ushort)ERes.BoxBlue] = new object[] { "BoxBlue" };
            // _resArr[(ushort)ERes.BoxBlack] = new object[] { "BoxBlack" };
            // _resArr[(ushort)ERes.BoxWhite] = new object[] { "BoxWhite" };

            // _resArr[(ushort)ERes.SplhUIA1] = new object[] { EType.GO, new byte[] { (byte)EResLbl.UI, (byte)EResLbl.SplhUI }, "SplhUI1", null };
            // _resArr[(ushort)ERes.SplhUIA2] = new object[] { EType.GO, new byte[] { (byte)EResLbl.UI, (byte)EResLbl.SplhUI }, "SplhUI2", null };
            // _resArr[(ushort)ERes.CubeRed] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test1 }, "CubeRed", null };
            // _resArr[(ushort)ERes.SphereRed] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test1 }, "SphereRed", null };
            // _resArr[(ushort)ERes.CylinderRed] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test1 }, "CylinderRed", null };
            // _resArr[(ushort)ERes.Red] = new object[] { EType.Mat, new byte[] { (byte)EResLbl.test2 }, "Red", null };
            // _resArr[(ushort)ERes.Green] = new object[] { EType.Mat, new byte[] { (byte)EResLbl.test2 }, "Green", null };
            // _resArr[(ushort)ERes.Blue] = new object[] { EType.Mat, new byte[] { (byte)EResLbl.test2 }, "Blue", null };
            // _resArr[(ushort)ERes.BoxRed] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test3 }, "BoxRed", null };
            // _resArr[(ushort)ERes.BoxGreen] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test3 }, "BoxGreen", null };
            // _resArr[(ushort)ERes.BoxBlue] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test3 }, "BoxBlue", null };
            // _resArr[(ushort)ERes.BoxBlack] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test3 }, "BoxBlack", null };
            // _resArr[(ushort)ERes.BoxWhite] = new object[] { EType.GO, new byte[] { (byte)EResLbl.test3 }, "BoxWhite", null };
        }
    }
}
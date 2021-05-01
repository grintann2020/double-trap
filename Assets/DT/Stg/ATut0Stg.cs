using UnityEngine;
using T;

namespace DT {

    public class ATut0Stg : Stg, IStg {

        public ATut0Stg() {
            
        }

        public void Imp() {
            // SpcMgr.Ins.Alt((byte)ESpc.A0, (byte)A0Spc.EAlt.Spc02);
            SpcMgr.Ins.Abstr((byte)ESpc.A0, new SCoord3(0.0f, 0.0f, 0.0f));
            SpcMgr.Ins.Cnstr((byte)ESpc.A0);
            Debug.Log("ATut0Stg Imp()");
        }

        // public void Beg() {

        // }

        public void Play() {

        }

        // public void End() {

        // }
        
        public void Clr() {

        }
    }
}
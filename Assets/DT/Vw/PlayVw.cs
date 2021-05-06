using System;
using UnityEngine;
using T;

namespace DT {

    public class PlayVw : Vw, IVw {

        public enum EPrj {
            PA, PB
        }

        public enum EOrnt {
            OA, OB
        }

        public enum EMov {
            M1, M2, M3
        }

        // public PlayVw(SCamPrj defProj, SOrnt3 defOrnt) : base(defProj, defOrnt) {
        public PlayVw() {
            _prjArr = new SCamPrj[Enum.GetNames(typeof(EPrj)).Length];
            _prjArr[(byte)EPrj.PA] = new SCamPrj(true, 5.0f, float.NaN, false, 0.3f, 1000.0f);
            _prjArr[(byte)EPrj.PB] = new SCamPrj(false, float.NaN, 40, false, 0.3f, 1000.0f);

            _orntArr = new SOrnt3[Enum.GetNames(typeof(EOrnt)).Length];
            _orntArr[(byte)EOrnt.OA] = new SOrnt3(new SCoord3(30.0f, 30.0f, 30.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _orntArr[(byte)EOrnt.OB] = new SOrnt3(new SCoord3(45.0f, 45.0f, 45.0f), new SCoord3(0.0f, 0.0f, 0.0f));

            _dMovArr = new _dMov[Enum.GetNames(typeof(EMov)).Length];
            _dMovArr[(byte)EMov.M1] = Mov1;
            _dMovArr[(byte)EMov.M2] = Mov2;
            _dMovArr[(byte)EMov.M3] = Mov3;

            _dflPrj = _prjArr[(byte)EPrj.PA];
            _dflOrnt = _orntArr[(byte)EOrnt.OA];
        }

        public override void Stup(Camera cam) {
            base.Stup(cam);
        }

        public override void Stdn() {
            base.Stdn();
        }

        public void Mov1() {
            // Debug.Log("PlayVw -- P1()");
        }

        public void Mov2() {
            // Debug.Log("PlayVw -- P2()");
        }

        public void Mov3() {
            // Debug.Log("PlayVw -- P3()");
        }
    }
}
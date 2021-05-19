using System;
using UnityEngine;
using T;

namespace DT {

    public class Ex0Stg : Stg, IStg {

        public enum EAct : byte {
            A, B, C, D
        }

        public enum ECond : byte {
            A0, A1, B0, B1, B2, C0
        }

        private int aaa, bbb, ccc = 0;

        public Ex0Stg() {
            _dBgnArr = new _dBgn[Enum.GetNames(typeof(EAct)).Length];
            _dBgnArr[(byte)EAct.A] = BgnA;
            _dBgnArr[(byte)EAct.B] = BgnB;
            _dBgnArr[(byte)EAct.C] = BgnC;
            _dBgnArr[(byte)EAct.D] = End;

            _dUpdArr = new _dUpd[Enum.GetNames(typeof(EAct)).Length];
            _dUpdArr[(byte)EAct.A] = UpdA;
            _dUpdArr[(byte)EAct.B] = UpdB;
            _dUpdArr[(byte)EAct.C] = UpdC;
            _dUpdArr[(byte)EAct.D] = null;

            _dCondArr = new _dCond[Enum.GetNames(typeof(ECond)).Length];
            _dCondArr[(byte)ECond.A0] = CondA0;
            _dCondArr[(byte)ECond.A1] = CondA1;
            _dCondArr[(byte)ECond.B0] = CondB0;
            _dCondArr[(byte)ECond.B1] = CondB1;
            _dCondArr[(byte)ECond.B2] = CondB2;
            _dCondArr[(byte)ECond.C0] = CondC0;

            _prcsArr = new byte[Enum.GetNames(typeof(EAct)).Length][][];
            _prcsArr[(byte)EAct.A] = new byte[2][] {
                new byte [PR] {(byte)ECond.A0, (byte)EAct.B},
                new byte [PR] {(byte)ECond.A1, (byte)EAct.B},
            };
            _prcsArr[(byte)EAct.B] = new byte[3][] {
                new byte [PR] {(byte)ECond.B0, (byte)EAct.C},
                new byte [PR] {(byte)ECond.B1, (byte)EAct.C},
                new byte [PR] {(byte)ECond.B2, (byte)EAct.D},
            };
            _prcsArr[(byte)EAct.C] = new byte[1][] {
                new byte [PR] {(byte)ECond.C0, (byte)EAct.A},
            };

            _prcsArr[(byte)EAct.D] = new byte[0][];
        }

        public override void Imp() {
            SpcMgr.Ins.Cnstr((byte)ESpc.A0, new SCoord3(0.0f, 0.0f, 0.0f));
            SpcMgr.Ins.Estb((byte)ESpc.A0);
            // SpcMgr.Ins.Dcstr((byte)ESpc.A0);
            base.Imp();
        }

        private void BgnA() {

            // Debug.Log("ATut0Stg -- BgnA -- aaa = " + aaa);
        }

        private void BgnB() {
            // Debug.Log("ATut0Stg -- BgnB -- bbb = " + bbb);
        }

        private void BgnC() {
            // Debug.Log("ATut0Stg -- BgnC -- ccc = " + ccc);
        }

        private void End() {
            StgMgr.Ins.Imp((byte)EStg.Ex1);
            // StgMgr.Ins.Act((byte)EStg.ATut1);
            // Debug.Log("ATut0Stg -- End");
        }

        private void UpdA() {
            aaa += 1;
            // Debug.Log("ATut0Stg -- UpdA aaa = " + aaa);
        }

        private void UpdB() {
            bbb += 1;
            // Debug.Log("ATut0Stg -- UpdB bbb = " + bbb);
        }

        private void UpdC() {
            ccc += 1;
            // Debug.Log("ATut0Stg -- UpdC ccc = " + ccc);
        }

        private bool CondA0() {
            if (aaa == 3) {
                // Debug.Log("ATut0Stg -- CondA0 -- aaa = " + aaa);
                return true;
            } else {
                return false;
            }
        }

        private bool CondA1() {
            if (aaa == 6) {
                // Debug.Log("ATut0Stg -- CondA1 -- aaa = " + aaa);
                return true;
            } else {
                return false;
            }
        }

        private bool CondB0() {
            if (bbb == 4) {
                // Debug.Log("ATut0Stg -- CondB0 -- bbb = " + bbb);
                return true;
            } else {
                return false;
            }
        }

        private bool CondB1() {
            return false;
        }

        private bool CondB2() {
            if (bbb == 8) {
                // Debug.Log("ATut0Stg -- CondB2 -- bbb = " + bbb);
                return true;
            } else {
                return false;
            }
        }

        private bool CondC0() {
            if (ccc == 3) {
                // Debug.Log("ATut0Stg -- CondC0 -- ccc = " + ccc);
                return true;
            } else {
                return false;
            }
        }
    }
}
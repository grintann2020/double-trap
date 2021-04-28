using UnityEngine;
using System;
using T;

namespace DT {

    public class A0Spc : Spc, ISpc {

        public enum EAlt {
            Spc01, Spc02
        }

        private const ushort ROWS = 6;
        private const ushort COLS = 6;
        private const ushort LAYS = 2;

        public A0Spc(ISS iSS) : base(iSS) {
            _dflArr = new ushort[ROWS][][];
            _dflArr[0] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[1] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[2] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[3] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[4] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[5] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _curArr = _dflArr;

            _dAltArr = new _dAlt[Enum.GetNames(typeof(EAlt)).Length];
            _dAltArr[(byte)EAlt.Spc01] = Spc01;
            _dAltArr[(byte)EAlt.Spc02] = Spc02;
        }

        public void Spc01() {
            Debug.Log("Alt --> Spc01");
        }

        public void Spc02() {
            Debug.Log("Alt --> Spc02");
        }
    }
}
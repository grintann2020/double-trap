using UnityEngine;
using System;
using T;

namespace DT {

    public class A1Spc : Spc, ISpc {

        public enum EAlt {
            Spc11, Spc12
        }

        private const ushort ROWS = 4;
        private const ushort COLS = 4;
        private const ushort LAYS = 1;

        public A1Spc(ISS iSS) : base(iSS) {
            _dflArr = new ushort[ROWS][][];
            _dflArr[0] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _dflArr[1] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _dflArr[2] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _dflArr[3] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _curArr = _dflArr;

            _dAltArr = new _dAlt[Enum.GetNames(typeof(EAlt)).Length];
            _dAltArr[(byte)EAlt.Spc11] = Spc11;
            _dAltArr[(byte)EAlt.Spc12] = Spc12;
        }

        public void Spc11() {
            Debug.Log("Alt --> Spc11");
        }

        public void Spc12() {
            Debug.Log("Alt --> Spc12");
        }
    }
}
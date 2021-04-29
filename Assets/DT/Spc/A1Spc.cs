using UnityEngine;
using System;
using T;

namespace DT {

    public class A1Spc : Spc, ISpc {

        public enum EAlt : byte {
            Spc11, Spc12
        }

        private const byte ROWS = 4;
        private const byte COLS = 4;
        private const byte LAYS = 1;

        public A1Spc(ISS iSS) : base(iSS) {
            _dflArr = new byte[ROWS][][];
            _dflArr[0] = new byte[COLS][] { new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1} };
            _dflArr[1] = new byte[COLS][] { new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1} };
            _dflArr[2] = new byte[COLS][] { new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1} };
            _dflArr[3] = new byte[COLS][] { new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1}, new byte[LAYS] {1} };
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
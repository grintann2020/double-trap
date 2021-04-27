using UnityEngine;
using System;
using T;

namespace DT {

    public class A1SS : SS, ISS {

        public enum EAlt {
            SS11, SS12
        }

        private const ushort ROWS = 4;
        private const ushort COLS = 4;
        private const ushort LAYS = 1;

        public A1SS() {
            _dflArr = new ushort[ROWS][][];
            _dflArr[0] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _dflArr[1] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _dflArr[2] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _dflArr[3] = new ushort[COLS][] { new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1}, new ushort[LAYS] {1} };
            _curArr = _dflArr;

            _dAltArr = new _dAlt[Enum.GetNames(typeof(EAlt)).Length];
            _dAltArr[(byte)EAlt.SS11] = SS11;
            _dAltArr[(byte)EAlt.SS12] = SS12;
        }

        public void SS11() {
            Debug.Log("Alt --> SS11");
        }

        public void SS12() {
            Debug.Log("Alt --> SS12");
        }
    }
}
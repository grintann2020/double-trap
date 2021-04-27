using UnityEngine;
using System;
using T;

namespace DT {

    public class A0SS : SS, ISS {

        public enum EAlt {
            SS01, SS02
        }

        private const ushort ROWS = 6;
        private const ushort COLS = 6;
        private const ushort LAYS = 2;

        public A0SS() {
            _dflArr = new ushort[ROWS][][];
            _dflArr[0] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[1] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[2] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[3] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[4] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _dflArr[5] = new ushort[COLS][] { new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 }, new ushort[LAYS] { 1, 1 } };
            _curArr = _dflArr;

            _dAltArr = new _dAlt[Enum.GetNames(typeof(EAlt)).Length];
            _dAltArr[(byte)EAlt.SS01] = SS01;
            _dAltArr[(byte)EAlt.SS02] = SS02;
        }

        public void SS01() {
            Debug.Log("Alt --> SS01");
        }

        public void SS02() {
            Debug.Log("Alt --> SS02");
        }
    }
}
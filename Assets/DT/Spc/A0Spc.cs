using UnityEngine;
using System;
using T;

namespace DT {

    public class A0Spc : Spc, ISpc {

        public enum EAlt : byte {
            Spc01, Spc02
        }

        public enum EObj : byte {
            None, TileRed , TileGreen, TileBlue
        }

        private const byte ROWS = 6;
        private const byte COLS = 6;
        private const byte LAYS = 2;

        public A0Spc(ISS iSS) : base(iSS) {
            _dAltArr = new _dAlt[Enum.GetNames(typeof(EAlt)).Length];
            _dAltArr[(byte)EAlt.Spc01] = Spc01;
            _dAltArr[(byte)EAlt.Spc02] = Spc02;

            _objArr = new string[Enum.GetNames(typeof(EObj)).Length];
            _objArr[(byte)EObj.TileRed] = "TileRed";
            _objArr[(byte)EObj.TileGreen] = "TileGreen";
            _objArr[(byte)EObj.TileBlue] = "TileBlue";

            _dflArr = new byte[ROWS][][];
            _dflArr[0] = new byte[COLS][] { new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 } };
            _dflArr[1] = new byte[COLS][] { new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 } };
            _dflArr[2] = new byte[COLS][] { new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 } };
            _dflArr[3] = new byte[COLS][] { new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 } };
            _dflArr[4] = new byte[COLS][] { new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 } };
            _dflArr[5] = new byte[COLS][] { new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 }, new byte[LAYS] { (byte)EObj.TileRed, 0 } };
            _curArr = _dflArr;
        }

        public void Spc01() {
            Debug.Log("Alt --> Spc01");
        }

        public void Spc02() {
            Debug.Log("Alt --> Spc02");
        }
    }
}
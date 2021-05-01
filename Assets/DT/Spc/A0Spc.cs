using UnityEngine;
using System;
using T;

namespace DT {

    public class A0Spc : Spc, ISpc {

        public enum EAlt : byte {
            Spc01, Spc02
        }

        public enum EU : byte {
            None, TileRed, TileGreen, TileBlue
        }

        private const byte ROWS = 8;
        private const byte COLS = 8;
        private const byte LAYS = 2;

        public A0Spc(ISS iSS) : base(iSS) {
            _dAltArr = new _dAlt[Enum.GetNames(typeof(EAlt)).Length];
            _dAltArr[(byte)EAlt.Spc01] = Spc01;
            _dAltArr[(byte)EAlt.Spc02] = Spc02;

            _uArr = new string[Enum.GetNames(typeof(EU)).Length][];
            _uArr[(byte)EU.TileRed] = new string[] { "TileRed" };
            _uArr[(byte)EU.TileGreen] = new string[] { "TileGreen" };
            _uArr[(byte)EU.TileBlue] = new string[] { "TileBlue" };

            _dflArr = new byte[ROWS][][];
            _dflArr[0] = new byte[COLS][] {
                new byte[LAYS] { 0, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { 0, 0 }
            };
            _dflArr[1] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }
            };
            _dflArr[2] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { 0, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { 0, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }
            };
            _dflArr[3] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { 0, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }
            };
            _dflArr[4] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { 0, 0 }
            };
            _dflArr[5] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }
            };
            _dflArr[6] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { 0, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }
            };
            _dflArr[7] = new byte[COLS][] {
                new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileRed, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileBlue, 0 }, new byte[LAYS] { (byte)EU.TileGreen, 0 }
            };
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
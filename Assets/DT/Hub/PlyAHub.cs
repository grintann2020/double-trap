using System;
using UnityEngine;
using T;

namespace DT {

    public class PlyAHub : Hub, IHub {
        
        public enum EGO {
            A1, A2, A3
        }

        public enum EVal {
            VA1, VA2, VA3, VA4, VA5,
        }

        public enum EAct {
            AAct0, AAct1
        }

        public enum EMot {
            AMot0, AMot1
        }

        public PlyAHub() {
            _goArr = new GameObject[Enum.GetNames(typeof(EGO)).Length];
            _valArr = new object[Enum.GetNames(typeof(EVal)).Length];
            _actArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];
            _actArr[(byte)EAct.AAct0] = AAct0;
            _actArr[(byte)EAct.AAct1] = AAct1;
            
            _motArr = new _dMot[Enum.GetNames(typeof(EMot)).Length];
            _motArr[(byte)EMot.AMot0] = AStp0;
            _motArr[(byte)EMot.AMot1] = AStp1;

            _frgArr = new _dFrg[Enum.GetNames(typeof(EMot)).Length];
            _frgArr[(byte)EMot.AMot0] = AFrg0;
            _frgArr[(byte)EMot.AMot1] = AFrg1;
        }

        public void AAct0() {

        }

        public void AAct1() {

        }

        public void AAct2() {

        }

        public void AStp0() {

        }

        public void AStp1() {

        }

        public void AStp2() {

        }

        public bool AFrg0() {
            return true;
        }

        public bool AFrg1() {
            return true;
        }
    }
}
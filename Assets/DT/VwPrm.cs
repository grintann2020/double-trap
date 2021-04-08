using System;
using UnityEngine;
using T;

namespace DT {

    public enum ECamPrj : byte {
        Menu, Play
    }

    public enum EVw : byte {
        Menu, Play
    }

    public class VwPrm : IVwPrm {

        public SCamPrj[] SCamPrjArr { get { return _sCamPrjArr; } }
        public IVw[] IVwArr { get { return _iVwArr; } }
        private SCamPrj[] _sCamPrjArr = new SCamPrj[Enum.GetNames(typeof(ECamPrj)).Length];
        private IVw[] _iVwArr = new IVw[Enum.GetNames(typeof(EVw)).Length];

        private SCamPrj _menuCamPrj = new SCamPrj(true, 20.0f, float.NaN, false, 0.3f, 1000.0f);
        private SCamPrj _playCamPrj = new SCamPrj(false, float.NaN, 40, false, 0.3f, 1000.0f);

        private MenuVw _menuVw = new MenuVw();
        private PlayVw _playVw = new PlayVw();

        public VwPrm() {

            _sCamPrjArr[(byte)ECamPrj.Menu] = _menuCamPrj;
            _sCamPrjArr[(byte)ECamPrj.Play] = _playCamPrj;

            _iVwArr[(byte)EVw.Menu] = _menuVw;
            _iVwArr[(byte)EVw.Play] = _playVw;
        }
    }
}
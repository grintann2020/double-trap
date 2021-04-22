using System;
using T;

namespace DT {

    public enum ECamPrj : byte {
        Menu, Play
    }

    public enum EVwOrnt : byte {
        Menu, Play0, Play1, Play2, Play3,
    }

    public enum EVw : byte {
        Menu, Play
    }

    public class VwPrm : IVwPrm {

        public SCamPrj[] SPrjArr { get { return _sPrjArr; } }
        public SOrnt3[] SOrntArr { get { return _sOrntArr; } }
        public IVw[] IVwArr { get { return _iVwArr; } }
        private SCamPrj[] _sPrjArr = new SCamPrj[Enum.GetNames(typeof(ECamPrj)).Length];
        private SOrnt3[] _sOrntArr = new SOrnt3[Enum.GetNames(typeof(EVwOrnt)).Length];
        private IVw[] _iVwArr = new IVw[Enum.GetNames(typeof(EVw)).Length];
        private static SCamPrj _menuPrj = new SCamPrj(true, 10.0f, float.NaN, false, 0.3f, 1000.0f);
        private static SCamPrj _playPrj = new SCamPrj(false, float.NaN, 40, false, 0.3f, 1000.0f);
        private static SOrnt3 _menuOrnt = new SOrnt3(new SCoord3(20.0f, 20.0f, 20.0f), new SCoord3(0.0f, 0.0f, 0.0f));
        private static SOrnt3 _play0Ornt = new SOrnt3(new SCoord3(12.0f, 13.0f, 15.0f), new SCoord3(0.0f, 0.0f, 0.0f));
        private static SOrnt3 _play1Ornt = new SOrnt3(new SCoord3(10.0f, 10.0f, 10.0f), new SCoord3(0.0f, 0.0f, 0.0f));
        private static SOrnt3 _play2Ornt = new SOrnt3(new SCoord3(10.0f, 10.0f, 10.0f), new SCoord3(0.0f, 0.0f, 0.0f));
        private static SOrnt3 _play3Ornt = new SOrnt3(new SCoord3(10.0f, 10.0f, 10.0f), new SCoord3(0.0f, 0.0f, 0.0f));
        private FstVw _menuVw = new FstVw(_menuPrj, _menuOrnt);
        private PlayVw _playVw = new PlayVw(_playPrj, _play0Ornt);

        public VwPrm() {
            _sPrjArr[(byte)ECamPrj.Menu] = _menuPrj;
            _sPrjArr[(byte)ECamPrj.Play] = _playPrj;
            _sOrntArr[(byte)EVwOrnt.Menu] = _menuOrnt;
            _sOrntArr[(byte)EVwOrnt.Play0] = _play0Ornt;
            _iVwArr[(byte)EVw.Menu] = _menuVw;
            _iVwArr[(byte)EVw.Play] = _playVw;
        }
    }
}
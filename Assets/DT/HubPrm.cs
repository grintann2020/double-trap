using System;
using T;

namespace DT {

    public enum EHub : byte {
        PlyA, PlyB,
    }

    public class HubPrm : IHubPrm {
        
        public IHub[] IHubArr { get { return _iHubArr; } }
        private IHub[] _iHubArr = new IHub[Enum.GetNames(typeof(EHub)).Length];

        public HubPrm() {
            _iHubArr[(byte)EHub.PlyA] = new PlyAHub();
            _iHubArr[(byte)EHub.PlyB] = new PlyBHub();
        }
    }
}
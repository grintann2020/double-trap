using System.Collections.Generic;

namespace T {
    
    public enum EUI {
        Menu, 
    }

    public class UIMgr : Singleton<UIMgr> {

        private Dictionary<EUI, IUI> _uiDic = new Dictionary<EUI, IUI>();
    }
}
using System;
using UnityEngine;

namespace T {
    
    [CreateAssetMenu(fileName = "Settings", menuName = "ScriptableObject/Settings", order = 0)]
    public class Settings : ScriptableObject {

        public EGame EGame;
        public ScrRez ScrRez;
        // private PrimeMgr _primeMgr = new PrimeMgr();

        // public IPrime IPrime {
        //     get { return _primeMgr.Fetch(EGame); }
        // }
    }
}
using UnityEngine;
using T;

namespace DT {

    public class StgPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            // Debug.Log("StgPgm InvkUpd()");
        }

        public void Exe() {
            Debug.Log("StgPgm Exe()");

            
        }

        public void End() {

        }
    }
}
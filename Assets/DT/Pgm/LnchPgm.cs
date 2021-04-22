using UnityEngine;
using T;

namespace DT {

    public class LnchPgm : IPgm {

        public IPgm Next { get; set; }

        public void InvkUpd() {
            // Debug.Log("LnchPgmPgm -- InvkUpd()");
        }

        public void Exe() {
            // Debug.Log("LnchPgmPgm -- Exe()");
        }

        public void End() {

        }
    }
}
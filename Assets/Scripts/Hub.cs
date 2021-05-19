using System;

namespace T {

    public class Hub {

        public bool IsConn { get { return _isConn; } }
        private bool _isConn;

        public virtual void Conn() {
            _isConn = true;
        }

        public virtual void Dscn() {
            _isConn = false;
        }

        public void InvkUpd() {
            if (_isConn == false) {
                return;
            }
        }
    }
}
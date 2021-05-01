using UnityEngine;

namespace T {

    public class Blk {
        
        public SGrid3 Grid { get { return _grid; } }
        public SCoord3 Coord { get { return _coord; } }
        public ushort Row { get { return _grid.Row; } }
        public ushort Col { get { return _grid.Col; } }
        public ushort Lay { get { return _grid.Lay; } }
        public float X { get { return _coord.X; } }
        public float Z { get { return _coord.Z; } }
        public float Y { get { return _coord.Y; } }
        public byte EU { get; set; }
        private SGrid3 _grid;
        private SCoord3 _coord;
        private GameObject[] _goArr;

        public Blk(SGrid3 grid, SCoord3 coord) {
            _grid = grid;
            _coord = coord;
            _goArr = new GameObject[0];
        }

        public void Inp(GameObject go) {
            _goArr = Arr.Add<GameObject>(_goArr, go);
        }

        public void Otp(ushort idx) {
            _goArr = Arr.Rmv<GameObject>(_goArr, idx);
        }
    }
}
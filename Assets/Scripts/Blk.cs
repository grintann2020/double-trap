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
        private SGrid3 _grid;
        private SCoord3 _coord;

        public Blk(SGrid3 grid, SCoord3 coord) {
            _grid = grid;
            _coord = coord;
        }
    }
}
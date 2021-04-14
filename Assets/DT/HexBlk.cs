using T;

namespace DT {

    public class HexBlk : Blk, IBlk {

        public HexBlk E { get { return _adjArr[0]; } set { _adjArr[0] = value; } }
        public HexBlk NE { get { return _adjArr[1]; } set { _adjArr[1] = value; } }
        public HexBlk NW { get { return _adjArr[2]; } set { _adjArr[2] = value; } }
        public HexBlk W { get { return _adjArr[3]; } set { _adjArr[3] = value; } }
        public HexBlk SW { get { return _adjArr[4]; } set { _adjArr[4] = value; } }
        public HexBlk SE { get { return _adjArr[5]; } set { _adjArr[5] = value; } }
        public HexBlk[] AdjArr { get { return _adjArr; } }
        protected HexBlk[] _adjArr;

        public HexBlk(SGrid3 grid, SCoord3 coord) : base(grid, coord) {
            _adjArr = new HexBlk[] {
                null, null, null, null, null, null,
            };
        }
    }
}
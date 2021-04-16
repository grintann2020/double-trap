using T;

namespace DT {

    public class SquBlk : Blk, IBlk {

        public SquBlk N { get { return _adjArr[0]; } set { _adjArr[0] = value; } }
        public SquBlk S { get { return _adjArr[1]; } set { _adjArr[1] = value; } }
        public SquBlk W { get { return _adjArr[2]; } set { _adjArr[2] = value; } }
        public SquBlk E { get { return _adjArr[3]; } set { _adjArr[3] = value; } }
        public SquBlk NW { get { return _adjArr[4]; } set { _adjArr[4] = value; } }
        public SquBlk NE { get { return _adjArr[5]; } set { _adjArr[5] = value; } }
        public SquBlk SW { get { return _adjArr[6]; } set { _adjArr[6] = value; } }
        public SquBlk SE { get { return _adjArr[7]; } set { _adjArr[7] = value; } }
        public SquBlk[] AdjArr { get { return _adjArr; } }
        protected SquBlk[] _adjArr;
        
        public SquBlk(SGrid3 grid, SCoord3 coord) : base(grid, coord) {
            _adjArr = new SquBlk[] {
                null, null, null, null, null, null, null, null,
            };
        }
    }
}
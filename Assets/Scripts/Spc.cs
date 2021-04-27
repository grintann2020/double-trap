namespace T {

    public class Spc {

        protected byte _uWd; // unit width
        protected byte _uHt; // unit height
        protected IBlk[][] _iBlkArr; // interface of the array of blocks

        public IBlk[][] Abstr(ushort[][] objArr) {
            ushort rows = (ushort)objArr.GetLength(0);
            ushort cols = (ushort)objArr.GetLength(1);
            // _iBlkArr = new SquBlk[rows][];
            return _iBlkArr;
            // SCoord2 startPos = _calc.GetCntr(cols, rows, colSpacing, rowSpacing);
        }
    }
}
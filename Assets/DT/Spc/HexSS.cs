using T;

namespace DT {

    public enum EHexDir { // don't move the enum to namespace T
        E, NE, NW, W, SW, SE,
    }

    public class HexSS : SS, ISS {

        public HexSS(byte uWd, byte uHt) : base(uWd, uHt) {

        }

        // public override byte[] TTT(byte[] bArr) {
        //     return bArr;
        // }

        public override IBlk[][][] Abstr(byte[][][] eObjArr, SCoord3 ctr) {
            // float uWd = 1.0f;
            // float unitWidth = (HEXSCALE * uWd) / 2;
            // float unitHeight = (2 * uWd) / 4;
            // float rowSpacing = unitWidth * 2;
            // float colSpacing = unitHeight * 3;

            byte rows = (byte)eObjArr.GetLength(0);
            byte cols = (byte)eObjArr.GetLength(1);
            IBlk[][][] iBlkArr = new HexBlk[rows][][];

            (float colSpacing, float rowSpacing) = HexCalc.DistributeDist((float)_uWd);
            SCoord3 orgPos = HexCalc.CenterPos(cols, rows, colSpacing, rowSpacing);

            for (byte r = 0; r < rows; r++) {
                for (byte c = 0; c < cols; c++) {
                    // for (byte l = 0; l < lays; l++) {
                    if (eObjArr[r][c][0] == 0) {
                        iBlkArr[r][c][0] = null;
                    } else {
                        float x = orgPos.X + c * colSpacing;
                        float y = orgPos.Y;
                        float z = orgPos.Z - r * rowSpacing;
                        // x += this.hexCalc.UnitWidth((float)uWd) * (row & 1);
                        if (r % 2 != 0) {
                            x += HexCalc.UnitW(HexCalc.HexW((float)_uWd));
                        }
                        iBlkArr[r][c][0] = new HexBlk(new SGrid3(r, c, 0), new SCoord3(x, y, z));
                    }
                    // }
                }
            }

            // for (int row = 0; row < rows; row++) {
            //     for (int col = 0; col < cols; col++) {
            //         if (_iBlkArr[row, col] == null) {
            //             continue;
            //         }

            //         if (col < cols - 1) {
            //             int[] dir = _hexCalc.Adjacency(row, (int)EHexDir.E);
            //             _iBlkArr[row, col].E = _iBlkArr[row + dir[0], col + dir[1]];
            //         }

            //         if (row > 0 && col < cols - 1) {
            //             int[] dir = _hexCalc.Adjacency(row, (int)EHexDir.NE);
            //             _iBlkArr[row, col].NE = _iBlkArr[row + dir[0], col + dir[1]];
            //         }

            //         if (row > 0 && col > 0) {
            //             int[] dir = _hexCalc.Adjacency(row, (int)EHexDir.NW);
            //             _iBlkArr[row, col].NW = _iBlkArr[row + dir[0], col + dir[1]];
            //         }

            //         if (col > 0) {
            //             int[] dir = _hexCalc.Adjacency(row, (int)EHexDir.W);
            //             _iBlkArr[row, col].W = _iBlkArr[row + dir[0], col + dir[1]];
            //         }

            //         if (row < rows - 1 && col > 0) {
            //             int[] dir = _hexCalc.Adjacency(row, (int)EHexDir.SW);
            //             _iBlkArr[row, col].SW = _iBlkArr[row + dir[0], col + dir[1]];
            //         }

            //         if (row < rows - 1 && col < cols - 1) {
            //             int[] dir = _hexCalc.Adjacency(row, (int)EHexDir.SE);
            //             _iBlkArr[row, col].SE = _iBlkArr[row + dir[0], col + dir[1]];
            //         }
            //     }
            // }
            return iBlkArr;
        }

        
        // public override void Cnstr(byte[][][] eObjArr, string[] uArr) {
        public override void Cnstr(IBlk[][][] iBlkArr, string[][] uArr) {
        }
    }
}
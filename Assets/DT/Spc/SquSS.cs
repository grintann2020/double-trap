using System;
using UnityEngine;
using T;

namespace DT {

    // public enum ESquDir : byte { // don't move the enum to namespace T
    //     N, E, W, S, NW, NE, SW, SE,
    // }

    public class SquSS : SS, ISS {

        public SquSS(byte uWd, byte uHt) : base(uWd, uHt) {

        }

        public override IBlk[][][] Cnstr(byte[][][] eUArr, SCoord3 ctr) {
            byte rows = (byte)eUArr.Length;
            byte cols = (byte)eUArr[0].Length;
            byte lays = (byte)eUArr[0][0].Length;
            // Debug.Log("rows --> " + rows + ", cols --> " + cols + ", lays --> " + lays);

            IBlk[][][] iBlkArr = new SquBlk[rows][][];
            SCoord3 org = SquCalc.Org(rows, cols, _uWd);
            for (byte r = 0; r < rows; r++) {
                iBlkArr[r] = new SquBlk[cols][];
                for (byte c = 0; c < cols; c++) {
                    iBlkArr[r][c] = new SquBlk[lays];
                    for (byte l = 0; l < lays; l++) {
                        if (eUArr[r][c][l] == 0) {
                            iBlkArr[r][c][l] = null;
                        } else {
                            float x = org.X + c * _uWd;
                            float y = org.Y + l * _uHt;
                            float z = org.Z - r * _uWd;
                            iBlkArr[r][c][l] = new SquBlk(new SGrid3(r, c, l), new SCoord3(x, y, z));
                            iBlkArr[r][c][l].EU = eUArr[r][c][l];
                        }
                    }
                }
            }

            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < cols; c++) {
                    for (int l = 0; l < lays; l++) {
                        if (iBlkArr[r][c][l] == null) {
                            continue;
                        }
                        if (r < rows - 1) {
                            // iBlkArr[r][c][l].E = iBlkArr[r][c];
                        }

                        // if (row > 0 && col < cols - 1) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.NE);
                        //     iBlkArr[row, col].NE = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (row > 0 && col > 0) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.NW);
                        //     iBlkArr[row, col].NW = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (col > 0) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.W);
                        //     iBlkArr[row, col].W = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (row < rows - 1 && col > 0) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.SW);
                        //     iBlkArr[row, col].SW = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (row < rows - 1 && col < cols - 1) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.SE);
                        //     iBlkArr[row, col].SE = iBlkArr[row + dir[0], col + dir[1]];
                        // }
                    }
                }
            }
            return iBlkArr;
        }

        public override void Estb(IBlk[][][] iBlkArr, string[][] uArr) {
            for (byte r = 0; r < iBlkArr.Length; r++) {
                for (byte c = 0; c < iBlkArr[r].Length; c++) {
                    for (byte l = 0; l < iBlkArr[r][c].Length; l++) {
                        if (iBlkArr[r][c][l] == null) {
                            continue;
                        }
                        IBlk tmpBlk = iBlkArr[r][c][l];
                        for (byte u = 0; u < uArr[tmpBlk.EU].Length; u++) {
                            ResMgr.Ins.Inst(
                                uArr[tmpBlk.EU][u],
                                new Vector3(tmpBlk.X, tmpBlk.Y, tmpBlk.Z),
                                Quaternion.identity,
                                null,
                                (GameObject res) => {
                                    tmpBlk.MI(res);
                                }
                            );
                        }
                    }
                }
            }
        }

        public override void Elim(IBlk[][][] iBlkArr) {
            for (byte r = 0; r < iBlkArr.Length; r++) {
                for (byte c = 0; c < iBlkArr[r].Length; c++) {
                    for (byte l = 0; l < iBlkArr[r][c].Length; l++) {
                        if (iBlkArr[r][c][l] == null) {
                            continue;
                        }
                        IBlk tmpBlk = iBlkArr[r][c][l];
                        ResMgr.Ins.Rls<GameObject>(
                            tmpBlk.GoArr,
                            () => {
                                tmpBlk.MO();
                            }
                        );
                    }
                }
            }
        }
    }
}

// namespace T {
//     public class Space {

//         public void Construct(int[,] hexData, ESize size) {
//             int rows = hexData.GetLength(0);
//             int cols = hexData.GetLength(1);
//             HexArr = new Hex[rows, cols];
//             // float size = 1.0f;
//             // float unitWidth = (HEXSCALE * size) / 2;
//             // float unitHeight = (2 * size) / 4;
//             // float rowSpacing = unitWidth * 2;
//             // float colSpacing = unitHeight * 3;
//             (float colSpacing, float rowSpacing) = _hexCalc.DistributeDist((float)size);
//             Coord startPos = _hexCalc.CenterPos(cols, rows, colSpacing, rowSpacing);
//             for (int row = 0; row < rows; row++) {
//                 for (int col = 0; col < cols; col++) {
//                     if (hexData[row, col] == -1) {
//                         HexArr[row, col] = null;
//                     } else {
//                         float x = startPos.X + col * colSpacing;
//                         float y = startPos.Y;// + (float)hexData[row, col];
//                         float z = startPos.Z - row * rowSpacing;
//                         // x += this.hexCalc.UnitWidth((float)size) * (row & 1);
//                         if (row % 2 != 0) {
//                             x += _hexCalc.UnitW(_hexCalc.HexW((float)size));
//                         }
//                         HexArr[row, col] = new Hex(new Grid(row, col), new Coord(x, y, z));
//                     }
//                 }
//             }

//             for (int row = 0; row < rows; row++) {
//                 for (int col = 0; col < cols; col++) {
//                     if (HexArr[row, col] == null) {
//                         continue;
//                     }

//                     if (col < cols - 1) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.E);
//                         HexArr[row, col].E = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row > 0 && col < cols - 1) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.NE);
//                         HexArr[row, col].NE = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row > 0 && col > 0) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.NW);
//                         HexArr[row, col].NW = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (col > 0) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.W);
//                         HexArr[row, col].W = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row < rows - 1 && col > 0) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.SW);
//                         HexArr[row, col].SW = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row < rows - 1 && col < cols - 1) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESquDir.SE);
//                         HexArr[row, col].SE = HexArr[row + dir[0], col + dir[1]];
//                     }
//                 }
//             }
//         }
//         public void Instantiate2(Entity hex) {
//             NativeArray<Entity> entityArr = new NativeArray<Entity>(HexArr.Length, Allocator.TempJob);
//             for (int row = 0; row < HexArr.GetLength(0); row++) {
//                 for (int col = 0; col < HexArr.GetLength(1); col++) {
//                     if (HexArr[row, col] == null) {
//                         continue;
//                     }
//                     int indexOfGrid = (row * HexArr.GetLength(1)) + col;
//                     entityArr[indexOfGrid] = _ecs.EntityMgr.Instantiate(hex);
//                     _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new Translation
//                     {
//                         Value = new float3(
//                             HexArr[row, col].X,
//                             HexArr[row, col].Y,
//                             HexArr[row, col].Z
//                         )
//                     });
//                     // _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new MyOwnColor
//                     // {
//                     //     Value = new float4(0.0f, row * 0.2f, col * 0.1f, col * 0.001f)
//                     // });

//                     // _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new MaterialColor
//                     // {
//                     //     Value = new float4(0.0f, row * 0.2f, col * 0.1f, 0.5f)

//                     // });
//                     // Debug.Log("MaterialColor");
//                 }
//             }
//             entityArr.Dispose();
//         }
//         public void Instantiate() {
//             // entityArr = new NativeArray<Entity>(HexArr.Length, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);
//             // NativeArray<Entity> entityArr = new NativeArray<Entity>(HexArr.Length, Allocator.TempJob);
//             Entity[] entityArr = new Entity[HexArr.Length];
//             for (int row = 0; row < HexArr.GetLength(0); row++) {
//                 for (int col = 0; col < HexArr.GetLength(1); col++) {
//                     if (HexArr[row, col] == null) {
//                         continue;
//                     }
//                     int indexOfGrid = (row * HexArr.GetLength(1)) + col;
//                     // Debug.Log(indexOfGrid);
//                     entityArr[indexOfGrid] = _ecs.EntityMgr.Instantiate(
//                         _ecs.EntityDict[EEntity.Hex_0]
//                     // _ecs.EntityDict[EEntity.Hex_0][
//                     //     UnityEngine.Random.Range(0, _ecs.EntityDict[EEntity.Hex_0].Count)
//                     // ]
//                     );
//                     _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new Translation
//                     {
//                         Value = new float3(
//                             HexArr[row, col].X,
//                             HexArr[row, col].Y,
//                             HexArr[row, col].Z
//                         )
//                     });
//                     _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new MyOwnColor
//                     {
//                         Value = new float4(0.0f, row * 0.2f, col * 0.1f, col * 0.001f)
//                     });
//                     // _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new PhysicsCollider
//                     // {
//                     // });
//                     // _ecs.EntityMgr.SetComponentData(entityArr[indexOfGrid], new MaterialColor
//                     // {
//                     //     Value = new float4(0.0f, row * 0.2f, col * 0.1f, 0.5f)

//                     // });
//                     // Debug.Log("MaterialColor");
//                 }
//             }
//             // entityArr.Dispose();
//         }
//     }
// }
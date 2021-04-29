using UnityEngine;
using T;

namespace DT {

    public enum ESqu3Dir : byte { // don't move the enum to namespace T
        N, E, W, S, NW, NE, SW, SE,
    }

    public class Squ3SS : SS, ISS {

        public Squ3SS(byte uWd, byte uHt) : base(uWd, uHt) {

        }

        public override IBlk[][][] Abstr(byte[][][] eObjArr, SCoord3 ctr) {
            byte rows = (byte)eObjArr.GetLength(0);
            byte cols = (byte)eObjArr[0].GetLength(0);
            byte lays = (byte)eObjArr[0][0].GetLength(0);
            Debug.Log("rows --> " + rows + ", cols --> " + cols + ", lays --> " + lays);

            IBlk[][][] iBlkArr = new SquBlk[rows][][];
            SCoord3 org = SquCalc.Org(rows, cols, _uWd);
            for (byte r = 0; r < rows; r++) {
                iBlkArr[r] = new SquBlk[cols][];
                for (byte c = 0; c < cols; c++) {
                    iBlkArr[r][c] = new SquBlk[lays];
                    for (byte l = 0; l < lays; l++) {
                        if (eObjArr[r][c][l] == 0) {
                            iBlkArr[r][c][l] = null;
                        } else {
                            float x = org.X + c * _uWd;
                            float y = org.Y + l * _uHt;
                            float z = org.Z - r * _uWd;
                            iBlkArr[r][c][l] = new SquBlk(new SGrid3(r, c, l), new SCoord3(x, y, z));
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
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.NE);
                        //     iBlkArr[row, col].NE = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (row > 0 && col > 0) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.NW);
                        //     iBlkArr[row, col].NW = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (col > 0) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.W);
                        //     iBlkArr[row, col].W = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (row < rows - 1 && col > 0) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.SW);
                        //     iBlkArr[row, col].SW = iBlkArr[row + dir[0], col + dir[1]];
                        // }

                        // if (row < rows - 1 && col < cols - 1) {
                        //     int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.SE);
                        //     iBlkArr[row, col].SE = iBlkArr[row + dir[0], col + dir[1]];
                        // }
                    }
                }
            }

            return iBlkArr;
        }

        public override void Cnstr(byte[][][] eObjArr, string[] objArr) {
            
        }
    }
}

// namespace T {
//     public class Space {
//         // public const float HEX_RADIAN = 1.0472f;
//         public Hex[,] HexArr = null;
//         private ECS _ecs = null;
//         private HexCalc _hexCalc = null;
//         // [WriteOnly, NativeDisableParallelForRestriction] NativeArray<Entity> entityArr;
//         // [NativeDisableContainerSafetyRestriction] NativeArray<Entity> entityArr;

//         public void Init() {

//         }

//         public void Bind(ECS eCS, HexCalc hexCalc) {
//             _ecs = eCS;
//             _hexCalc = hexCalc;
//         }

//         // public void Create(int cols, int rows, Size size)
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
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.E);
//                         HexArr[row, col].E = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row > 0 && col < cols - 1) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.NE);
//                         HexArr[row, col].NE = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row > 0 && col > 0) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.NW);
//                         HexArr[row, col].NW = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (col > 0) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.W);
//                         HexArr[row, col].W = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row < rows - 1 && col > 0) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.SW);
//                         HexArr[row, col].SW = HexArr[row + dir[0], col + dir[1]];
//                     }

//                     if (row < rows - 1 && col < cols - 1) {
//                         int[] dir = _hexCalc.Adjacency(row, (int)ESqu3Dir.SE);
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
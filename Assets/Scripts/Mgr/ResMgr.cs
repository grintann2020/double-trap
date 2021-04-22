using System;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine;

namespace T {

    public class ResMgr : Sgltn<ResMgr> {
        // _resArr[eRes][0].GetType() -- System.String -- key of asset in AddressableAsset Group
        // _resArr[eRes][1].GetType() -- TObject
        public delegate void Loaded();
        // public delegate void Loaded<T>(T obj);
        // public delegate void LoadedArr<T>(T[] obj);
        public delegate void Rlsed();
        private object[][] _resArr;

        public void Bind(IResPrm iResPrm) {
            _resArr = iResPrm.ResArr;
        }

        public void Init() {

        }

        public T Get<T>(ushort eRes) {
            return (T)_resArr[eRes][1];
        }

        // public void Load<T>(ushort eRes, Loaded<T> loaded) {
        //     Addressables.LoadAssetAsync<T>(_resArr[eRes][1]).Completed += (AsyncOperationHandle<T> hdl) => {
        //         loaded(hdl.Result);
        //     };
        // }

        public void Load<T>(ushort eRes, Loaded loaded) {
            Addressables.LoadAssetAsync<T>(_resArr[eRes][1]).Completed += (AsyncOperationHandle<T> hdl) => {
                loaded();
            };
        }

        public async void Load<T>(ushort[] eResArr, Loaded loaded) {
            eResArr = RmvExst(eResArr);
            Task[] taskArr = new Task[eResArr.Length];
            AsyncOperationHandle[] hdlArr = new AsyncOperationHandle[eResArr.Length];
            for (ushort e = 0; e < eResArr.Length; e++) {
                hdlArr[e] = Addressables.LoadAssetAsync<T>(_resArr[eResArr[e]][0]);
                taskArr[e] = hdlArr[e].Task;
            }
            await Task.WhenAll(taskArr);
            for (ushort e = 0; e < eResArr.Length; e++) {
                _resArr[eResArr[e]][1] = hdlArr[e].Result;
            }
            loaded();
        }

        public void Rls<T>(T obj, Rlsed rlsed) {
            Addressables.Release<T>(obj);
            rlsed();
        }

        public void Rls<T>(T[] objArr, Rlsed rlsed) {
            for (ushort o = 0; o < objArr.Length; o++) {
                Addressables.Release<T>(objArr[o]);
            }
            rlsed();
        }

        public void Load(ushort eRes/*, _loaded loaded*/) {
            switch (_resArr[eRes][0]) {
                case EType.GO: Addressables.LoadAssetAsync<GameObject>(_resArr[eRes][2]); break;
                case EType.Mat: Addressables.LoadAssetAsync<Material>(_resArr[eRes][2]); break;
                case EType.Spr: Addressables.LoadAssetAsync<Sprite>(_resArr[eRes][2]); break;
                case EType.Txr: Addressables.LoadAssetAsync<Texture>(_resArr[eRes][2]); break;
                default: Addressables.LoadAssetAsync<GameObject>(_resArr[eRes][2]); break;
            }
        }

        private ushort[] RmvExst(ushort[] orgArr) {
            ushort[] newArr = new ushort[0];
            for (ushort o = 0; o < orgArr.Length; o++) {
                if (_resArr[orgArr[o]][1] == null) {
                    newArr = Arr.Affx<ushort>(newArr, orgArr[o]);
                }
            }
            return newArr;
        }

        // public object[][] Cpy(ushort eRes) {
        //     return (object[][])_resArr[eRes];
        // }

        // public object[][] Ftch(ushort eResLbl) {
        //     object[][] objArr = new object[0][];
        //     for (ushort r = 0; r < _resArr.Length; r++) {
        //         byte[] lblArr = (byte[])_resArr[r][1];
        //         for (byte l = 0; l < lblArr.Length; l++) {
        //             if (lblArr[l] == eResLbl) {
        //                 objArr = Arr.Affx<object[]>(objArr, _resArr[r]);
        //             }
        //         }
        //     }
        //     return objArr;
        // }

        // public async void LoadArr<T>(string[] keyArr, LoadedArr<T> loadedArr) {
        //     T[] tArr = new T[keyArr.Length];
        //     Task[] taskArr = new Task[keyArr.Length];
        //     AsyncOperationHandle<T>[] hdlArr = new AsyncOperationHandle<T>[keyArr.Length];
        //     for (byte k = 0; k < keyArr.Length; k++) {
        //         hdlArr[k] = Addressables.LoadAssetAsync<T>(keyArr[k]);
        //         taskArr[k] = hdlArr[k].Task;
        //     }
        //     await Task.WhenAll(taskArr);
        //     for (byte t = 0; t < keyArr.Length; t++) {
        //         tArr[t] = hdlArr[t].Result;
        //     }
        //     loadedArr(tArr);
        // }
    }
}
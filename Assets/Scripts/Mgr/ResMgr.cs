using UnityEngine.AddressableAssets;
using UnityEngine;

namespace T {

    public class ResMgr : Singleton<ResMgr> {

        private object[][] _resArr;

        public void Bind(IResPrm iResPrm) {
            _resArr = iResPrm.ResArr;
        }

        public void Init() {

        }

        public void Get() {

        }

        public void Load(ushort res) {
            // _resArr[res][0].GetType() -- T.EType
            // _resArr[res][1].GetType() -- System.Byte -- (byte)Game.EResLbl
            // _resArr[res][2].GetType() -- System.String -- key of asset in AddressableAsset Group
            switch (_resArr[res][0]) {
                case EType.GO: Addressables.LoadAssetAsync<GameObject>(_resArr[res][2]); break;
                case EType.Mat: Addressables.LoadAssetAsync<Material>(_resArr[res][2]); break;
                case EType.Spr: Addressables.LoadAssetAsync<Sprite>(_resArr[res][2]); break;
                case EType.Txr: Addressables.LoadAssetAsync<Texture>(_resArr[res][2]); break;
                default: Addressables.LoadAssetAsync<GameObject>(_resArr[res][2]); break;
            }

        }
    }
}
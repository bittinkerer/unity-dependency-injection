using Cinemachine;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CamerasProviders {
  internal class TagVirtualCamerasProvider : BaseProvider<VirtualCameras> {
    [SerializeField] private string _tag;

    public override VirtualCameras Get(object data = null) =>
      GameObject.FindGameObjectWithTag(_tag).GetComponent<CinemachineVirtualCamera>();
  }
}

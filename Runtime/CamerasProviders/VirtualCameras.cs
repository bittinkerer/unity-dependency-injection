using System.Collections.Generic;
using Cinemachine;

namespace Assets.Scripts.Core.Providers.CamerasProviders {
  internal class VirtualCameras : OneOrMany<CinemachineVirtualCamera> {
    public VirtualCameras(IEnumerable<CinemachineVirtualCamera> values) : base(values) {
    }

    // syntactic sugar
    public static implicit operator VirtualCameras(CinemachineVirtualCamera value) => new(new CinemachineVirtualCamera[] { value });
    public static implicit operator VirtualCameras(CinemachineVirtualCamera[] cameras) => new(cameras);
  }
}

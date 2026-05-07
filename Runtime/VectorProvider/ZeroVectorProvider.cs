using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class ZeroVectorProvider : BaseProvider<Vector3> {
    public override Vector3 Get(object data = null) => Vector3.zero;
  }
}

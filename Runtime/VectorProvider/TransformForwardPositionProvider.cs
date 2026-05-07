using Packages.Esteny.Providers.TransformProviders;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  internal class TransformForwardPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Transforms> _transformsProvider;
    [SerializeField] private float _distanceInForwardDirection;

    public override Vector3 Get(object data = null) {
      Transform transform = _transformsProvider.Get(data);
      return transform.position + transform.forward * _distanceInForwardDirection;
    }
  }
}

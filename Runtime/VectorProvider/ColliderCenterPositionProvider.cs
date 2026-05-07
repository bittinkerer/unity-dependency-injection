using Assets.Scripts.Core.Providers.CollidersProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class ColliderCenterPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Colliders> _colliderProvider;

    public override Vector3 Get(object data = null) {
      Collider collider = _colliderProvider.Get(data);
      return collider.bounds.center;
    }
  }
}
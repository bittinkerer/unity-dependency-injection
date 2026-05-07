using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  internal class ColliderCenterBottomPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Collider> _colliderProvider;
    [SerializeField] private Vector3 _offset = Vector3.zero;

    public override Vector3 Get(object data = null) =>
      _colliderProvider.Get(data).bounds.center - new Vector3(0, _colliderProvider.Get(data).bounds.extents.y, 0) + _offset;
  }
}

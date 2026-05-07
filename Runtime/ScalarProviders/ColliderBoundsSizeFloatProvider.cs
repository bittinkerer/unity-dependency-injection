using Assets.Scripts.Core.Enums;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders {
  internal class ColliderBoundsSizeFloatProvider : BaseProvider<float> {
    [SerializeField] private BaseProvider<Collider> _colliderProvider;
    [SerializeField] private DimensionType          _dimensionType;
    [SerializeField] private float                  _factor = 1f;

    public override float Get( object data = null ) => _dimensionType switch {
      DimensionType.DEPTH =>
        _colliderProvider.Get(data).bounds.extents.x * 2 * _factor,
      DimensionType.HEIGHT =>
        _colliderProvider.Get( data ).bounds.extents.y * 2 * _factor,
      DimensionType.WIDTH =>
        _colliderProvider.Get( data ).bounds.extents.z * 2 * _factor,
    };
  }
}

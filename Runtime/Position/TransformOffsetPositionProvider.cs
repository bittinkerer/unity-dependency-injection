using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class TransformOffsetPositionProvider : BasePositionProvider
  {
    [SerializeField] private Transform _positionTransform;
    [SerializeField] private Vector3 _transformOffset;

    public override Vector3 Get(object data = null) =>
      _positionTransform.position + _transformOffset;
  }
}

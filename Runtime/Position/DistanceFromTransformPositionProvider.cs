using UnityEngine;
using Packages.Estenis.UnityExts_;
using Packages.Estenis.BoxPositionProviders_;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class DistanceFromTransformPositionProvider : BasePositionProvider
  {
    [SerializeField] private Transform _origin;
    [SerializeField] private Vector2 _offset;

    public override Vector3 Get(object data = null) =>
        (_origin == null
            ? this.gameObject.GetRoot().transform.position
            : _origin.position)
        + _offset.ToYZVector3();
  }
}
using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class VerticalDistancePositionProvider : BasePositionProvider
  {
    [SerializeField] private Transform _origin;
    [SerializeField] private float _distance;
    [SerializeField] private bool _isBackwards;

    public override Vector3 Get(object data = null) =>
        _origin.position
        + (_isBackwards ? -1 * this.transform.up : this.transform.up) * _distance;

  }
}

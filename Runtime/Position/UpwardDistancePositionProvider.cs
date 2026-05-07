using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class UpwardDistancePositionProvider : BasePositionProvider
  {
    [SerializeField] private BasePositionProvider _originPositionProvider;
    [SerializeField] private float _distance;
    [SerializeField] private bool _isBackwards;

    public override Vector3 Get(object data = null) =>
        _originPositionProvider != null
        ? _originPositionProvider.Get() + (_isBackwards ? -1 * this.transform.up : this.transform.up) * _distance
        : this.gameObject.transform.position + (_isBackwards ? -1 * Vector3.up : Vector3.up) * _distance;
  }
}

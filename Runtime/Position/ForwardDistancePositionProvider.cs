using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers
{
  internal class ForwardDistancePositionProvider : BasePositionProvider
  {
    [SerializeField] private BasePositionProvider _originPositionProvider;
    [SerializeField] private float _distance;
    [SerializeField] private bool _isBackwards;

    public override Vector3 Get(object data = null) =>
        _originPositionProvider != null
        ? _originPositionProvider.Get() + (_isBackwards ? -1 * this.transform.forward : this.transform.forward) * _distance
        : this.gameObject.transform.position + (_isBackwards ? -1 * Vector3.forward : Vector3.forward) * _distance;

  }
}
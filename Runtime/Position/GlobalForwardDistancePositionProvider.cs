using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class GlobalForwardDistancePositionProvider : BasePositionProvider
  {
    [SerializeField] private BaseProvider<Vector3> _currentPositionProvider;
    [SerializeField] private float _distance;

    public override Vector3 Get(object data = null) =>
      _currentPositionProvider.Get(data) + Vector3.forward * _distance;
    
  }
}

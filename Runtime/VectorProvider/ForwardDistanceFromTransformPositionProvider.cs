using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class ForwardDistanceFromTransformPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Transform> _transformProvider;
    [SerializeField] private float _distance;
    [SerializeField] private bool _inverse = false;

    public override Vector3 Get(object data = null) =>
      _transformProvider.Get(data).position + Vector3.forward * (_inverse ? -1 : 1) * _distance;
  }
}

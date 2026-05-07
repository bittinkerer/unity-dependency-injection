using Packages.Esteny.Providers.ComponentProviders;
using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders
{
  internal class SphereCastCollidersProvider : BaseProvider<Components>
  {
    [SerializeField] private BaseProvider<Vector3> _positionProvider;
    [SerializeField] private float _radius;
    [SerializeField] private bool _drawGizmos = false;

    private static Collider[] _colliders = new Collider[7];
    private Vector3 _position;

    public override Components Get(object data = null)
    {
      _position = _positionProvider.Get(data);
      int hits = 
        Physics.OverlapSphereNonAlloc(_position, 3f, _colliders, Physics.AllLayers, QueryTriggerInteraction.UseGlobal);
      return _colliders;
    }

    private void OnDrawGizmos()
    {
      if (!_drawGizmos) return;
      Gizmos.color = Color.yellow;
      Gizmos.DrawSphere(_position, _radius);
    }
  }
}

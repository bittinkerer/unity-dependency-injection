using Assets.Scripts.Core.Providers.CollidersProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers {
  internal class SphereOverlapCollidersProvider : BaseProvider<Colliders> {
    [SerializeField] private BaseProvider<Vector3> _positionProvider;
    [SerializeField] private BaseProvider<Vector3> _offsetProvider;
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private bool _drawGizmos = false;

    private Vector3 _position;

    public override Colliders Get(object data = null) {
      _position = _positionProvider.Get(data);
      if (_offsetProvider != null) {
        _position += _offsetProvider.Get(data);
      }
      var colliders = Physics.OverlapSphere(
                _position,
                _radius,
                _layerMask);
      return colliders;
    }

    private void OnDrawGizmos() {
      if (!_drawGizmos) return;
      Gizmos.color = Color.red;
      Gizmos.DrawSphere(_position, _radius);
    }
  }
}
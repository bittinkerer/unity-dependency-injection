using Assets.Scripts.Core.Providers;
using UnityEngine;

namespace Assets.Scripts.Core.ProvidersOverlap {
  internal class BoxOverlapCollidersProvider : BaseProvider<Colliders> {
    [SerializeField] private BaseProvider<Vector3>  _positionProvider;
    [SerializeField] private BaseProvider<Vector3>  _forwardDirectionProvider;
    [SerializeField] private BaseProvider<Vector3>  _boxDimensionsProvider;
    [SerializeField] private LayerMask              _layerMask ;
    [SerializeField] private bool                   _gizmosOn = false;

    private Vector3 _position; // for drawing gizmos
    private Vector3 _size = Vector3.zero;
    private Vector3 _direction;

    public override Colliders Get(object data = null) {
      _position     = _positionProvider.Get(data);
      _direction    = _forwardDirectionProvider.Get(data);
      _size         = _boxDimensionsProvider.Get(data);
      var colliders = Physics.OverlapBox(
                _position,
                _size / 2f,
                Quaternion.LookRotation(_direction),
                _layerMask);
      return colliders;
    }

    private void OnDisable( ) {
      _size = Vector3.zero;
    }

    void OnDrawGizmos() {
      if ( !_gizmosOn || _size == Vector3.zero) {
        return;
      }

      var position = _positionProvider.Get();
      var color = Color.orangeRed;
      color.a = 1f;
      Gizmos.color = color;
      Matrix4x4 rotationMatrix = Matrix4x4.TRS(_position, Quaternion.LookRotation(_direction), transform.lossyScale);
      Matrix4x4 defaultGizmosMatrix = Gizmos.matrix;
      Gizmos.matrix = rotationMatrix;
      Gizmos.DrawWireCube( Vector3.zero, _size );
      //Gizmos.DrawWireCube( position, _size );
      color.a = 0.5f;
      Gizmos.color = color;
      Gizmos.DrawCube( Vector3.zero, _size );
      //Gizmos.DrawCube( position, _size );
      color.a = 1f;
      Gizmos.DrawLine( Vector3.zero, Vector3.forward * 2); // Draw forward vector
      Gizmos.matrix = defaultGizmosMatrix;
    }
  }
}
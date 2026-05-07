using System;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  internal class ClosestSurfacePositionVectorProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Vector3>  _originPositionProvider;
    [SerializeField] private BaseProvider<Vector3>  _directionProvider;
    [SerializeField] private BaseProvider<float>    _maxDistanceProvider;
    [SerializeField] private LayerMask              _surfaceColliderLayer;
    [SerializeField] private bool                   _drawGizmos = false;

    Vector3 _origin;
    Vector3 _direction;
    float   _distance;

    public override Vector3 Get( object data = null ) {
      _origin      = _originPositionProvider.Get( data );
      _direction   = _directionProvider.Get( data );
      _distance    = _maxDistanceProvider.Get( data );

      //if(Physics.SphereCast(new Ray(_origin, _direction), 2, out RaycastHit hit, _distance, _surfaceColliderLayer)) {
      //  return hit.point; // consider that transform.center will be moved, so may need to account for only one-axis of movement
      //}

      if ( Physics.Raycast( new Ray( _origin, _direction ), out RaycastHit hit, _distance, _surfaceColliderLayer ) ) {
        return hit.point;
      }

      Debug.LogWarning( $"{this.gameObject.name}.{nameof( ClosestSurfacePositionVectorProvider )} found no surface and returned zero-vector" );
      return Vector3.zero;
    }

    private void OnDrawGizmos( ) {
      if(!_drawGizmos || _origin == Vector3.zero ) { return; }

      Gizmos.color = Color.yellow;
      Gizmos.DrawLine( _origin, _origin + ( _direction * _distance ) );
    }

    private void OnDisable( ) {
      _origin = Vector3.zero;
    }
  }
}

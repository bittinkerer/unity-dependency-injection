using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  /// <summary>
  /// Provides a position based off of a transform-direction, an initial position and an offset
  /// The resulting position consists of the initial position + the offset 
  /// (where offset's z-axis aligns with transform forward direction)
  ///   result-position = initial-position + offset (transformed by transformProvided forward-direction)
  /// </summary>
  internal class ForwardWithOffsetPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Transform>  _transformProvider;
    [SerializeField] private BaseProvider<Vector3>    _positionProvider;
    [SerializeField] private BaseProvider<Vector3>    _offsetProvider;
    [SerializeField] private bool                     _gizmosOn = false;

    private Transform   _transform  = null;
    private Vector3     _position   = Vector3.zero;
    private Vector3     _offset     = Vector3.zero;
 
    public override Vector3 Get( object data = null ) {
      _position   = _positionProvider.Get( data );
      _offset     = _offsetProvider.Get( data );
      _transform  = _transformProvider.Get(data);

      _offset = _transform.forward * _offset.z + _transform.up * _offset.y;
      return _position +  _offset;
    }

    private void OnDisable( ) {
      _transform = null;
    }

    private void OnDrawGizmos( ) {
      if ( !_gizmosOn || _transform == null) {
        return;
      }

      var color = Color.yellow;
      color.a = 1f;
      Gizmos.color = color;
      Gizmos.DrawSphere( _position + _offset, .2f );
    }
  }
}
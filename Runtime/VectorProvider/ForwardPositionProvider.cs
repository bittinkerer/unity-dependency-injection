using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  /// <summary>
  /// Returns a position based off of the forward-direction vector provided (normalized) multiplied by the distance provided
  /// and added to the position provided.
  /// Result = positionProvided + (forwardNormalizedProvided * distanceProvided)
  /// </summary>
  internal class ForwardPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Vector3>  _positionProvider;
    [SerializeField] private BaseProvider<Vector3>  _forwardDirectionProvider;
    [SerializeField] private BaseProvider<float>    _distanceProvider;
    [SerializeField] private BaseProvider<float>    _angleInDegreesProvider;
    [SerializeField] private bool                   _backwards = false;

    public override Vector3 Get( object data = null ) {
      var temp = 
        _positionProvider.Get( data ) 
        + _forwardDirectionProvider.Get( data ) * ( _backwards ? -1 : 1 ) * _distanceProvider.Get( data );
      
      var   position  = _positionProvider.Get( data );
      var   forward   = _forwardDirectionProvider.Get(data);
      var   distance  = _distanceProvider.Get( data ) * ( _backwards ? -1 : 1 );
      
      float angle     = 0;
      if ( _angleInDegreesProvider != null ) {
        angle = _angleInDegreesProvider.Get( data );
      }

      var direction = forward;
      // if angle > 0, rotate forward around x-axis
      if ( angle > 0 ) {
        direction = Quaternion.Euler( angle, 0, 0 ) * forward;
      }

      return position + (direction * distance) ;
    }
  }
}

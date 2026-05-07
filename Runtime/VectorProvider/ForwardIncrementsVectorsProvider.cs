using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class ForwardIncrementsVectorsProvider : BaseProvider<Vector3[]> {
    [SerializeField] private int                      _amount;
    [SerializeField] private float                    _angleIncrementInDegrees;
    [SerializeField] private BaseProvider<Transform>  _transformProvider;
    [SerializeField] private bool                     _includeForward = true;

    public override Vector3[] Get( object data = null ) {
      Transform forwardTransform = _transformProvider.Get(data);
      List<Vector3> result = new ();
      for ( int i = 0; i < _amount; i++ ) {
        var angle = _angleIncrementInDegrees * (_includeForward ? i : i + 1) % 360;
        angle = forwardTransform.forward.z > 0 ? -angle : angle; // make counter-clockwise
        var direction = Quaternion.Euler( angle, 0, 0 ) * forwardTransform.forward;
        result.Add( direction.normalized );
      }
      return result.ToArray();
    }
  }
}

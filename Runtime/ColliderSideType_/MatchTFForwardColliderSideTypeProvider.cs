using System;
using Assets.Scripts.Core.Enums;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ColliderSideType_ {
  internal class MatchTFForwardColliderSideTypeProvider : BaseProvider<ColliderSideType> {
    [SerializeField] private BaseProvider<Transform> _transformProvider;

    public override ColliderSideType Get( object data = null ) {
      var tr = _transformProvider.Get(data);
      
      if ( tr.forward == Vector3.forward ) {
        return ColliderSideType.FRONT;
      }
      else if ( tr.forward == -Vector3.forward ) {
        return ColliderSideType.BACK;
      }
      else if ( tr.forward == Vector3.up ) {
        return ColliderSideType.TOP;
      }
      else if ( tr.forward == -Vector3.up ) {
        return ColliderSideType.BOTTOM;
      }
      throw new ArgumentException( $"{nameof( MatchTFForwardColliderSideTypeProvider )} can only be used with (UP,DOWN,LEFT,RIGHT) facing transform" );
    }

  }
}

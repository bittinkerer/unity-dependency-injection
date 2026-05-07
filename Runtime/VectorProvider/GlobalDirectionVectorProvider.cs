using System;
using Assets.Scripts.Core.Enums;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class GlobalDirectionVectorProvider : BaseProvider<Vector3> {
    [SerializeField] private GlobalDirectionType _directionType;

    public override Vector3 Get( object data = null ) => _directionType switch {
      GlobalDirectionType.UP    => Vector3.up,
      GlobalDirectionType.DOWN  => Vector3.down,
      GlobalDirectionType.RIGHT => Vector3.right,
      GlobalDirectionType.LEFT  => Vector3.left,
      _ => throw new InvalidOperationException("Direction not recognized")
    };
      
  }
}

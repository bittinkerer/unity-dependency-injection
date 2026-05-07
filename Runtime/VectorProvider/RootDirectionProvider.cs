using System;
using Assets.Scripts.Core.Enums;
using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class RootDirectionProvider : BaseProvider<Vector3> {
    [SerializeField] private TransformDirectionType _directionType;
    [SerializeField] private bool                   _reverse;

    public override Vector3 Get( object data = null ) => _directionType switch {
      TransformDirectionType.FORWARD => 
        _reverse 
        ? -this.gameObject.GetRoot().transform.forward
        : this.gameObject.GetRoot().transform.forward,
      TransformDirectionType.UP =>
        _reverse
        ? -this.gameObject.GetRoot().transform.up
        : this.gameObject.GetRoot().transform.up,
      TransformDirectionType.RIGHT =>
        _reverse
        ? -this.gameObject.GetRoot().transform.right
        : this.gameObject.GetRoot().transform.right,
      _ => 
        throw new NotImplementedException(
          $"{this.gameObject.GetRoot().name}.{nameof(RootDirectionProvider)} direction Type not supported.")
    };
  }
}

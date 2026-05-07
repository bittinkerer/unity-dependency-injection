using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;
using Packages.Estenis.UnityExts_;
using System;

namespace Assets.Scripts.Providers
{
  public class DistanceFromTargetToThisPositionProvider : BasePositionProvider
  {
    [SerializeField] private float _distanceFromTarget;
    [SerializeField] private AxisDirectionType _directionAxis = AxisDirectionType.XYZ;
    [SerializeField] private Vector3 _offset = Vector3.zero;

    public override Vector3 Get(object data = null)
    {
      var target = (data as GameObject).GetRoot().transform.position + _offset;
      if(target == null)
      {
        //Debug.LogError($"Calling {nameof(DistanceFromTargetToThisPositionProvider)} with type that is not of GameObject or values are NULL.");
        return Vector3.zero;
      }

      var thisPosition = this.gameObject.GetRoot().transform.position;

      return _directionAxis switch
      {
        AxisDirectionType.XYZ =>
          target + (thisPosition - target).normalized * _distanceFromTarget,
        AxisDirectionType.Z =>
          new Vector3(
            thisPosition.x,
            thisPosition.y,
            target.z + _distanceFromTarget * (target.z - thisPosition.z < 0 ? 1 : -1)),
        _ => throw new NotSupportedException()
      };
    }
  }
}
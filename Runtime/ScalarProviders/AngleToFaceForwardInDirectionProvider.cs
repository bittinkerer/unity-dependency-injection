using System;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders
{
  internal class AngleToFaceForwardInDirectionProvider : BaseProvider<float>
  {
    [SerializeField] private BaseProvider<Transform> _transformProvider;
    [SerializeField] private BaseProvider<Vector3> _forwardDirectionVectorProvider;

    public override float Get(object data = null)
    {
      var transform = _transformProvider.Get(data);
      var directionToLookForward = _forwardDirectionVectorProvider.Get(data);
      var angle = Vector3.Angle(transform.forward, directionToLookForward);
      return angle;
    }
  }
}
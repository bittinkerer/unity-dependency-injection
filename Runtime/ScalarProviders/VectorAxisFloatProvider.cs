using System;
using Assets.Scripts.Core.Enums;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders {
  internal class VectorAxisFloatProvider : BaseProvider<float> {
    [SerializeField] private BaseProvider<Vector3> _vectorProvider;
    [SerializeField] private AxisType _axisType;

    public override float Get( object data = null ) => _axisType switch {
      AxisType.X => _vectorProvider.Get(data).x,
      AxisType.Y => _vectorProvider.Get(data).y,
      AxisType.Z => _vectorProvider.Get(data).z,
      _ => throw new NotImplementedException()
    };
  }
}

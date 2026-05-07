using System;
using Assets.Scripts.Core.Enums;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class TransformDirectionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Transform> _transformProvider;
    [SerializeField] private TransformDirectionType _directionType;
    [SerializeField] private bool _inverse = false;

    public override Vector3 Get(object data = null) => _directionType switch {
      TransformDirectionType.RIGHT => _transformProvider.Get(data).right * (_inverse ? -1f : 1f),
      TransformDirectionType.FORWARD => _transformProvider.Get(data).forward * (_inverse ? -1f : 1f),
      TransformDirectionType.UP => _transformProvider.Get(data).up * (_inverse ? -1f : 1f),
      _ => throw new NotSupportedException()
    };
  }
}

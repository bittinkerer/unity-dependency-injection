using System;
using Assets.Scripts.Core.Providers.TransformProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position {
  internal class TransformsPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Transforms> _transformsProvider;

    public override Vector3 Get(object data = null) {
      Transform providedTransform = _transformsProvider.Get(data);
      return providedTransform.position;
    }
  }
}

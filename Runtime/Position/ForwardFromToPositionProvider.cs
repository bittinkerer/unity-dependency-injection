using System;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position {
  internal class ForwardFromToPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Vector3> _directionProvider;
    [SerializeField] private BaseProvider<Transform> _moverTransformProvider;
    [SerializeField] private float _distance;

    public override Vector3 Get(object data = null) {
      throw new NotImplementedException();
    }
  }
}

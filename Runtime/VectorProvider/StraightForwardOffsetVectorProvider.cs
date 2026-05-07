using Assets.Scripts.Core.Providers.TransformProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class StraightForwardOffsetVectorProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Transforms> _transformsProvider;
    [SerializeField] private float _offset;

    public override Vector3 Get(object data = null) {
      Transform tf = _transformsProvider.Get(data);
      Vector3 result = Vector3.forward * _offset;
      if (tf.right.x < 0) { // facing right
        result *= -1;
      }

      return result;
    }
  }
}

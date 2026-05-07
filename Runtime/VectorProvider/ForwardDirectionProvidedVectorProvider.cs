using Assets.Scripts.Core.Providers.TransformProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class ForwardDirectionProvidedVectorProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Transforms> _transformsProvider;
    [SerializeField] private bool _reverse = false;

    public override Vector3 Get(object data = null) {
      Transform tr = _transformsProvider.Get(data);
      return tr.forward * (_reverse ? -1 : 1);
    }
  }
}

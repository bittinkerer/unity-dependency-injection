using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class ValueTransformsHybridProvider : BaseProvider<Transforms>
  {
    [SerializeField] private Transform[] _transforms;

    public override Transforms Get(object data = null) => _transforms;
  }
}

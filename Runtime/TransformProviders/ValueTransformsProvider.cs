using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class ValueTransformsProvider : BaseProvider<Transform[]>
  {
    [SerializeField] private Transform[] _transforms;

    public override Transform[] Get(object data = null)
    {
      return _transforms;
    }
  }
}

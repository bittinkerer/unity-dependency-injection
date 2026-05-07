using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class ValueTransformProvider : BaseProvider<Transform>
  {
    [SerializeField] private Transform _transform;

    public override Transform Get(object data = null)
    {
      return _transform;
    }
  }
}

using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders
{
  internal class ValueFloatProvider : BaseProvider<float>
  {
    [SerializeField] private float _value;

    public override float Get(object data = null) => _value;
  }
}

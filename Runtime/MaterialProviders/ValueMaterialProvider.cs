using UnityEngine;

namespace Assets.Scripts.Core.Providers.MaterialProviders
{
  internal class ValueMaterialProvider : BaseProvider<Material>
  {
    [SerializeField] private Material _material;

    public override Material Get(object data = null)
    {
      return _material;
    }
  }
}

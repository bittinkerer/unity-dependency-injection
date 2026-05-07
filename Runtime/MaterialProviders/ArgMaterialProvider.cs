using UnityEngine;

namespace Assets.Scripts.Core.Providers
{
  internal class ArgMaterialProvider : BaseProvider<Material>
  {
    public override Material Get(object data = null) =>
      data as Material;
  }
}

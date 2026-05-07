using UnityEngine;

namespace Packages.Esteny.Providers
{
  internal class ArgMaterialProvider : BaseProvider<Material>
  {
    public override Material Get(object data = null) =>
      data as Material;
  }
}

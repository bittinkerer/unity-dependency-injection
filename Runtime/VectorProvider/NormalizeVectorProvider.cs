using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class NormalizeVectorProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Vector3> _vectorProvider;

    public override Vector3 Get(object data = null) =>
      _vectorProvider.Get(data).normalized;
  }
}

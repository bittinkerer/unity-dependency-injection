using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  internal class FactorVectorProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Vector3> _vectorProvider;
    [SerializeField] private float _factor;

    public override Vector3 Get(object data = null) =>
      _vectorProvider.Get(data) * _factor;
  }
}

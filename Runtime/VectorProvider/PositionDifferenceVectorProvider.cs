using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class PositionDifferenceVectorProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Vector3> _fromPositionProvider;
    [SerializeField] private BaseProvider<Vector3> _toPositionProvider;

    public override Vector3 Get(object data = null) //=>
    {
      var result = _toPositionProvider.Get(data) - _fromPositionProvider.Get(data);
      return result;
    }
      //_toPositionProvider.Get(data) - _fromPositionProvider.Get(data);
  }
}

using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class MaskVectorProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Vector3> _vectorProvider;
    [SerializeField] private bool _maskX;
    [SerializeField] private float _maskXWithValue;
    [SerializeField] private bool _maskY;
    [SerializeField] private float _maskYWithValue;
    [SerializeField] private bool _maskZ;
    [SerializeField] private float _maskZWithValue;

    public override Vector3 Get(object data = null)
    {
      var providedVector = _vectorProvider.Get(data);
      var x = _maskX ? _maskXWithValue : providedVector.x;
      var y = _maskY ? _maskYWithValue : providedVector.y;
      var z = _maskZ ? _maskZWithValue : providedVector.z;
      return new Vector3(x, y, z);
    }
  }
}

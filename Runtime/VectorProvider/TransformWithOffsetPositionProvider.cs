using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class TransformWithOffsetPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Transform> _transformProvider;
    [SerializeField] private Vector3 _offset;

    public override Vector3 Get(object data = null) =>
      _transformProvider.Get(data).position + _offset;
  }
}

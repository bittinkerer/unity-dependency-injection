using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class ProvidedPositionOffsetPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Vector3> _positionProvider;
    [SerializeField] private Vector3 _offset;

    public override Vector3 Get(object data = null) =>
      _positionProvider.Get(data) + _offset;
  }
}
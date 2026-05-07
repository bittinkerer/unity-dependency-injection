using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class TransformPosProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Transform> _transformProvider;

    public override Vector3 Get(object data = null)
    {
      var transform = _transformProvider.Get(data);
      return transform.position;
    }
  }
}
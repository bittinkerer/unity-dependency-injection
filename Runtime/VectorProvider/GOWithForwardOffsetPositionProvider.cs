using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  internal class GOWithForwardOffsetPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<GameObject> _gameObjectProvider;
    [SerializeField][Tooltip("Can use negative values to offset away from forward direction")] 
    private Vector3 _forwardOffset;

    public override Vector3 Get(object data = null)
    {
      var go = _gameObjectProvider.Get(data);
      return go.transform.position + (go.transform.forward.z < 0 ? -_forwardOffset : _forwardOffset);
    }
  }
}
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class GameObjectPositionProvider : BaseVector3Provider
  {
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private BaseProvider<GameObject> _gameobjectProvider;
    [SerializeField] private Vector3 _offset = Vector3.zero;
    [SerializeField] private bool _drawGizmos = false;

    public override Vector3 Get(object data = null)
    {
      var gameobject = _gameObject;
      if(_gameobjectProvider != null)
      {
        gameobject = _gameobjectProvider.Get(data); 
      }
      return gameobject.transform.position + _offset;
    }

    private void OnDrawGizmos() {
      if (!_drawGizmos) return;
      var gameobject = _gameObject;
      if (_gameobjectProvider != null) {
        gameobject = _gameobjectProvider.Get();
      }
      Gizmos.color = Color.yellow;
      Gizmos.DrawSphere(gameobject.transform.position + _offset, .75f);
    }
  }
}
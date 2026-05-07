using UnityEngine;

namespace Packages.Esteny.Providers.RigidbodyProviders
{
  internal class GameObjectBodyProvider : BaseProvider<Rigidbody>
  {
    [SerializeField] private BaseProvider<GameObject> _gameObjectProvider;

    public override Rigidbody Get(object data = null)
    {
      var go = _gameObjectProvider.Get(data);
      return go.GetComponent<Rigidbody>();
    }
  }
}
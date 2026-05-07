using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ValueGameObjectProvider : BaseProvider<GameObject>
  {
    [SerializeField] private GameObject _gameObject;

    public override GameObject Get(object data = null)
    {
      return _gameObject;
    }
  }
}

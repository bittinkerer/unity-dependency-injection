using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders
{
  internal class ValueGameObjectColliderProvider : BaseProvider<Collider>
  {
    [SerializeField] private GameObject _gameObject;

    public override Collider Get(object data = null) =>
      _gameObject.GetComponent<Collider>();
  }
}

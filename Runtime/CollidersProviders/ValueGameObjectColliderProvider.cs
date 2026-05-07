using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders
{
  internal class ValueGameObjectColliderProvider : BaseProvider<Collider>
  {
    [SerializeField] private GameObject _gameObject;

    public override Collider Get(object data = null) =>
      _gameObject.GetComponent<Collider>();
  }
}

using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders
{
  internal class GameobjectCollidersProvider : BaseProvider<BoxColliders>
  {
    [SerializeField] private GameObject _gameobject;

    public override BoxColliders Get(object data = null) =>
      _gameobject.GetComponents<BoxCollider>();
  }
}

using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class FirstOfGOsGOProvider : BaseProvider<GameObject> {
    [SerializeField] private BaseProvider<GameObjects> _gameObjectsProvider;

    public override GameObject Get(object data = null) => _gameObjectsProvider.Get(data);

  }
}

using System.Linq;
using Assets.Scripts.Core.Providers.CollidersProviders;
using Assets.Scripts.Core.Providers.GameObjectProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectsProviders {
  internal class FromCollidersGameObjectsProvider : BaseProvider<GameObjects> {
    [SerializeField] private BaseProvider<Colliders> _collidersProvider;

    public override GameObjects Get(object data = null) {
      Collider[] colliders = _collidersProvider.Get(data);
      return colliders.Select(co => co.gameObject).ToArray();
    }
  }
}

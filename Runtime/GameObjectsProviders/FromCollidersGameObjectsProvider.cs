using System.Linq;
using UnityEngine;

namespace Packages.Esteny.Providers.GameObjectsProviders {
  internal class FromCollidersGameObjectsProvider : BaseProvider<GameObjects> {
    [SerializeField] private BaseProvider<Colliders> _collidersProvider;

    public override GameObjects Get(object data = null) {
      Collider[] colliders = _collidersProvider.Get(data);
      return colliders.Select(co => co.gameObject).ToArray();
    }
  }
}

using UnityEngine;

namespace Packages.Esteny.Providers.GameObjectsProviders {
  internal class TagGameObjectsProvider : BaseProvider<GameObjects> {
    [SerializeField] private string _tag;

    public override GameObjects Get(object data = null) => GameObject.FindGameObjectsWithTag(_tag);
  }
}

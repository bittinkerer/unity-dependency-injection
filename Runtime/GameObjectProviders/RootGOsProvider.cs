using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class RootGOsProvider : BaseProvider<GameObjects> {
    [SerializeField] private BaseProvider<GameObjects> _goProvider;

    public override GameObjects Get(object data = null) {
      GameObject go = _goProvider.Get(data);
      return go.GetRoot();
    }
  }
}
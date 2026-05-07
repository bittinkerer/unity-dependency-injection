using Packages.Estenis.UnityExts_;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class RootThisGOsProvider : BaseProvider<GameObjects> {
    public override GameObjects Get(object data = null) =>
      this.gameObject.GetRoot();
  }
}

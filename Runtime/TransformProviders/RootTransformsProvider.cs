using Packages.Estenis.UnityExts_;

namespace Assets.Scripts.Core.Providers.TransformProviders {
  internal class RootTransformsProvider : BaseProvider<Transforms> {

    public override Transforms Get(object data = null) =>
      this.gameObject.GetRoot().transform;
  }
}

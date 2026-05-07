using Packages.Estenis.UnityExts_;

namespace Packages.Esteny.Providers.TransformProviders {
  internal class RootTransformsProvider : BaseProvider<Transforms> {

    public override Transforms Get(object data = null) =>
      this.gameObject.GetRoot().transform;
  }
}

using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  internal class RootForwardDirectionProvider : BaseProvider<Vector3> {
    public override Vector3 Get(object data = null) =>
      this.gameObject.GetRoot().transform.forward;
  }
}

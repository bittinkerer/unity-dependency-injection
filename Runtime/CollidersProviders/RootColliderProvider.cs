using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders {
  internal class RootColliderProvider : BaseProvider<Collider> {

    public override Collider Get( object data = null ) =>
      this.gameObject.GetRoot().GetComponent<Collider>();
  }
}

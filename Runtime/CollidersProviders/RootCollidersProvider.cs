using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders {
  internal class RootCollidersProvider : BaseProvider<Colliders> {

    public override Colliders Get( object data = null ) =>
      this.gameObject.GetRoot().GetComponent<Collider>();
  }
}
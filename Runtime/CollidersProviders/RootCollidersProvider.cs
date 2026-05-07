using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class RootCollidersProvider : BaseProvider<Colliders> {

    public override Colliders Get( object data = null ) =>
      this.gameObject.GetRoot().GetComponent<Collider>();
  }
}
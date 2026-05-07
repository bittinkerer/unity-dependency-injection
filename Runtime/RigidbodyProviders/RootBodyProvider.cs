using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Packages.Esteny.Providers.RigidbodyProviders {
  internal class RootBodyProvider : BaseProvider<Rigidbody> {
    public override Rigidbody Get( object data = null ) =>
      this.gameObject.GetRoot().GetComponent<Rigidbody>();
  }
}

using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class RootPositionProvider : BaseProvider<Vector3> {
    public override Vector3 Get( object data = null ) =>
      this.gameObject.GetRoot().transform.position;
  }
}
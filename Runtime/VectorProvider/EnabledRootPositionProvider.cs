using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider {
  internal class EnabledRootPositionProvider : BaseProvider<Vector3> {
    [Header("Should be placed in a gameObject that is NOT disabled during game runtime")]
    private Vector3 _enabledPosition;

    protected override void OnEnable( ) {
      _enabledPosition = this.gameObject.GetRoot().transform.position;
    }

    public override Vector3 Get( object data = null ) => _enabledPosition;
  }
}

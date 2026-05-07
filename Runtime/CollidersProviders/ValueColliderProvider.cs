using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders {
  internal class ValueColliderProvider : BaseProvider<Collider> {
    [SerializeField] private Collider _collider;

    public override Collider Get( object data = null ) => _collider;
  }
}

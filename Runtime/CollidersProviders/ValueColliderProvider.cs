using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class ValueColliderProvider : BaseProvider<Collider> {
    [SerializeField] private Collider _collider;

    public override Collider Get( object data = null ) => _collider;
  }
}

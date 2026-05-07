using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders
{
  internal class ValueBoxColliderProvider : BaseProvider<BoxCollider>
  {
    [SerializeField] private BoxCollider _boxCollider;

    public override BoxCollider Get(object data = null) => _boxCollider;
  }
}
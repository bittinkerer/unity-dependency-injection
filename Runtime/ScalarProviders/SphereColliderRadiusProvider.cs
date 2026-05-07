using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders
{
  internal class SphereColliderRadiusProvider : BaseProvider<float>
  {
    [SerializeField] private SphereCollider _sphereCollider;

    public override float Get(object data = null) => _sphereCollider.radius;
  }
}

using UnityEngine;

namespace Packages.Esteny.Providers.CapsuleColliderProviders
{
  internal class ArgCapsuleColliderProvider : BaseProvider<CapsuleCollider>
  {

    public override CapsuleCollider Get(object data = null)
    {
      return data as CapsuleCollider;
    }
  }
}

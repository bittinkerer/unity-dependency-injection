using UnityEngine;

namespace Packages.Esteny.Providers.CollisionProviders
{
  internal class ArgCollisionProvider : BaseCollisionProvider
  {
    public override Collision Get(object data = null)
    {
      return (Collision)data;
    }
  }
}

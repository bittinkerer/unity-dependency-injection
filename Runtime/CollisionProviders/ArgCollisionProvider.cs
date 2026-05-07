using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollisionProviders
{
  internal class ArgCollisionProvider : BaseCollisionProvider
  {
    public override Collision Get(object data = null)
    {
      return (Collision)data;
    }
  }
}

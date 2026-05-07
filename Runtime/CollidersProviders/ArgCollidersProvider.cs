using System;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders
{
  internal class ArgCollidersProvider : BaseProvider<Colliders>
  {
    public override Colliders Get(object data = null) => data switch
    {
      Collider co => new(new Collider[] { co }),
      Collider[] cos => new(cos),
      _ => throw new NotSupportedException()
    };
  }
}
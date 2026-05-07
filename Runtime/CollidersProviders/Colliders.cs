using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Core.Providers.ButtonsProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers
{
  internal class Colliders : OneOrMany<Collider>
  {
    public Colliders(IEnumerable<Collider> values) : base(values)
    {
    }

    // syntactic sugar
    public static implicit operator Colliders(Collider[] colliders) => new(colliders);
    public static implicit operator Colliders(Collider collider) => new(new Collider[] { collider });
  }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Packages.Esteny.Providers.ButtonsProviders;
using UnityEngine;

namespace Packages.Esteny.Providers
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

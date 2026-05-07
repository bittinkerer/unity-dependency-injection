using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ComponentProviders
{
  internal class Components : OneOrMany<Component>
  {
    public Components(IEnumerable<Component> values) : base(values)
    {
    }

    // syntactic sugar
    public static implicit operator Components(Component value) => new(new Component[] { value });
    public static implicit operator Components(Component [] gos) => new(gos);
  }
}

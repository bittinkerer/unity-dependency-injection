using System;
using UnityEngine;

namespace Packages.Esteny.Providers.ComponentProviders {
  internal class ArgComponentsProvider : BaseProvider<Components> {
    public override Components Get(object data = null) => data switch {
      Component co => new Components(new Component[] {co}),
      Component[] cos => new Components(cos),
      _ => throw new NotSupportedException()
    };
  }
}

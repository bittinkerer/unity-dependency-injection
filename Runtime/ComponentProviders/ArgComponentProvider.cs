using UnityEngine;

namespace Packages.Esteny.Providers.ComponentProviders
{
  internal class ArgComponentProvider : BaseProvider<Component>
  {
    public override Component Get(object data = null) => data as Component;
  }
}

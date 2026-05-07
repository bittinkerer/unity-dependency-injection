using UnityEngine;

namespace Assets.Scripts.Core.Providers.ComponentProviders
{
  internal class ArgComponentProvider : BaseProvider<Component>
  {
    public override Component Get(object data = null) => data as Component;
  }
}

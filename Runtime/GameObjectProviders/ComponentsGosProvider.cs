using System.Linq;
using Assets.Scripts.Core.Providers.ComponentProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ComponentsGosProvider : BaseProvider<GameObjects>
  {
    [SerializeField] private BaseProvider<Components> _componentsProvider;

    public override GameObjects Get(object data = null)
    {
      Component[] components = _componentsProvider.Get(data);
      GameObject[] gos = components.Where(co => co != null).Select(co => co.gameObject).ToArray();
      return gos;
    }
  }
}

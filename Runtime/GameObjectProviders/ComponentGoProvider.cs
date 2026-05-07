using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ComponentGoProvider : BaseProvider<GameObject>
  {
    [SerializeField] private BaseProvider<Component> _componentProvider;

    public override GameObject Get(object data = null) => _componentProvider.Get(data).gameObject;
  }
}

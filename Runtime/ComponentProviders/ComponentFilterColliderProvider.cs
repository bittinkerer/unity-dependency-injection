using Packages.Estenis.BoxPositionProviders_;
using Packages.Estenis.UnityExts_;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ComponentCollider
{
  public class ComponentFilterColliderProvider : MonoBehaviour
  {
    [SerializeField] private BaseCollidersProvider _collidersProvider;
    [SerializeField] private Component _componentForType;

    public Collider Get(object offset = null)
    {
      var componentType = _componentForType.GetType();
      var colliders = _collidersProvider.Get(offset);
      var collider = colliders
          ?.FirstOrDefault(co => co.gameObject.GetRoot().TryGetComponent(componentType, out Component _));

      return collider;
    }
  }
}

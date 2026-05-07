using Assets.Scripts.Core.Decorators;
using Assets.Scripts.Core.Traits;
using Packages.Estenis.BoxPositionProviders_;
using Packages.Estenis.UnityExts_;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TraitColliderProviders
{
  internal class TraitsColliderProvider : BaseColliderProvider
  {
    [SerializeField] private BaseCollidersProvider _collidersProvider;
    [SerializeField] private List<TraitSO> _traits;

    public override Collider Get(object data = null)
    {
      var colliders = _collidersProvider.Get(data);
      var collider = colliders
        ?.FirstOrDefault(
          coll => 
               coll.gameObject.GetRoot().TryGetComponent<TraitCarrier>(out TraitCarrier traitCarrier) 
            && traitCarrier.Contains(_traits));
      return collider;
    }
  }
}
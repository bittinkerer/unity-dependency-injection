using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class FirstColliderProvider : BaseProvider<Collider> {
    [SerializeField] private BaseProvider<Colliders> _collidersProvider;

    public override Collider Get(object data = null) => 
      _collidersProvider.Get(data).FirstOrDefault();
  }
}

using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class ValueCollidersProvider : BaseProvider<Colliders> {
    [SerializeField] private List<Collider> colliders;

    public override Colliders Get(object data = null) =>
      new (colliders);
  }
}

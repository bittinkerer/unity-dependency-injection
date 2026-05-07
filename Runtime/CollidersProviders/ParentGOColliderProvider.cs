using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class ParentGOColliderProvider : BaseProvider<Collider> {

    public override Collider Get(object data = null) =>
      this.transform.parent.gameObject.GetComponent<Collider>();
  }
}

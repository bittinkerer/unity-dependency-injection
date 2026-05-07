using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class ParentGameObjectProvider : BaseProvider<GameObject> {
    public override GameObject Get(object data = null) => this.gameObject.transform.parent.gameObject;
  }
}

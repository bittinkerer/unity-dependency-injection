using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class RootGOProvider : BaseProvider<GameObject> {

    public override GameObject Get(object data = null) => 
      this.gameObject.GetRoot();
  }
}

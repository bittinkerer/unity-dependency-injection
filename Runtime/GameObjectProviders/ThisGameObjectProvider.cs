using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ThisGameObjectProvider : BaseProvider<GameObject>
  {
    public override GameObject Get(object data = null) => this.gameObject;
  }
}
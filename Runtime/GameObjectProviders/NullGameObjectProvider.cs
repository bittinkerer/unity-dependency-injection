using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class NullGameObjectProvider : BaseProvider<GameObject>
  {
    public override GameObject Get(object data = null) => null;
  }
}
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ArgGameObjectProvider : BaseProvider<GameObject>
  {
    public override GameObject Get(object data = null) =>
      data switch
      {
        Transform t => t.gameObject,
        GameObject go => go,
        Component c => c.gameObject,
        _ => null
      };
  }
}
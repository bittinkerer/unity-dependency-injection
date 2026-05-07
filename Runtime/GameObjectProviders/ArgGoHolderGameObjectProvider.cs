using Assets.Scripts.Core.Contracts;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ArgGoHolderGameObjectProvider : BaseProvider<GameObject>
  {
    public override GameObject Get(object data = null)
    {
      IGameObjectHolder goHolder = (IGameObjectHolder)data;
      return goHolder.GameObject;
    }
  }
}

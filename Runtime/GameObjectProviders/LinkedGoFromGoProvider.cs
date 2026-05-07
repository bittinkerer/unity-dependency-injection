using Assets.Scripts.Core.Attributes;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class LinkedGoFromGoProvider : BaseProvider<GameObject>
  {
    [SerializeField] private BaseProvider<GameObject> _goProvider;

    public override GameObject Get(object data = null)
    {
      GameObject go = _goProvider.Get(data);
      var linked = go.GetComponent<Linked>();
      return linked.GetLinkedGO();
    }
      
  }
}
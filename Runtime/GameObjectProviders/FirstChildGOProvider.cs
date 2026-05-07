using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class FirstChildGOProvider : BaseProvider<GameObject>
  {
    [SerializeField] private GameObject _parent;

    public override GameObject Get(object data) => _parent.transform.childCount > 0 
      ? _parent.transform.GetChild(0).gameObject
      : null;
  }
}

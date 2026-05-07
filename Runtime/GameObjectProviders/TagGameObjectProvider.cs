using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class TagGameObjectProvider : BaseProvider<GameObject> {
    [SerializeField] private string _tag;

    public override GameObject Get(object data = null) =>
      GameObject.FindGameObjectWithTag(_tag);
  }
}

using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders {
  internal class TagTransformsProvider : BaseProvider<Transforms> {
    [SerializeField] private string _tagName;

    public override Transforms Get(object data = null) => 
      GameObject.FindGameObjectWithTag(_tagName).transform;
  }
}

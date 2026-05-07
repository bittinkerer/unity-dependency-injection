using UnityEngine;

namespace Packages.Esteny.Providers.RectTransforms {
  internal class ValueRectTransformsProvider : BaseProvider<RectTransforms> {
    [SerializeField] private RectTransform[] _rectTransforms;

    public override RectTransforms Get(object data = null) =>
      _rectTransforms;
  }
}

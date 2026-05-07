using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.RectTransforms {
  internal class RectTransforms : OneOrMany<RectTransform> {
    public RectTransforms(IEnumerable<RectTransform> values) : base(values) {
    }

    // syntactic sugar
    public static implicit operator RectTransforms(RectTransform value) => new(new RectTransform[] { value });
    public static implicit operator RectTransforms(RectTransform[] Transforms) => new(Transforms);
  }
}

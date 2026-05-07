using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  [Serializable]
  internal class Transforms : OneOrMany<Transform>
  {
    public Transforms(IEnumerable<Transform> values) : base(values)
    {
    }

    // syntactic sugar
    public static implicit operator Transforms(Transform value) => new(new Transform[] { value });
    public static implicit operator Transforms(Transform[] Transforms) => new(Transforms);
  }
  
}

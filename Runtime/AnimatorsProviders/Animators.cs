using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.AnimatorsProviders {
  internal class Animators : OneOrMany<Animator> {
    public Animators(IEnumerable<Animator> values) : base(values) {
    }

    // syntactic sugar
    public static implicit operator Animators(Animator value) => new(new Animator[] { value });
    public static implicit operator Animators(Animator[] animators) => new(animators);
  }
}

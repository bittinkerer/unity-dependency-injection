using UnityEngine;

namespace Assets.Scripts.Core.Providers.AnimatorsProviders {
  internal class ValueAnimatorsProvider : BaseProvider<Animators> {
    [SerializeField] private Animator[] _animators;

    public override Animators Get(object data = null) => _animators;
  }
}

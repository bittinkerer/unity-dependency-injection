using UnityEngine;
using ZLinq;

namespace Assets.Scripts.Core.Providers.AnimatorsProviders {
  internal class FirstActiveChildOfAnimatorProvider : BaseProvider<Animator> {
    [SerializeField] private BaseProvider<GameObject> _animatorParentGOProvider;

    public override Animator Get( object data = null ) {
      var animator = _animatorParentGOProvider.Get( data ).transform
        .Descendants()
        .Where(tr => tr.gameObject.activeSelf && tr.gameObject.GetComponent<Animator>() != null)
        .Select(tr => tr.gameObject.GetComponent<Animator>())
        .FirstOrDefault();

      return animator;
    }
  }
}

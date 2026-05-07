using UnityEngine;
using UnityEngine.VFX;

namespace Assets.Scripts.Core.Providers.VisualEffectsProviders
{
  internal class TransformArgVisualEffectProvider : BaseProvider<VisualEffect>
  {
    public override VisualEffect Get(object data = null)
    {
      var transform = data as Transform;
      return transform.gameObject.GetComponent<VisualEffect>();
    }
  }
}

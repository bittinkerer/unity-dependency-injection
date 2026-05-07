using UnityEngine;
using UnityEngine.VFX;

namespace Assets.Scripts.Core.Providers.VisualEffectsProviders
{
  internal class GameObjectArgVisualEffectsProvider : BaseProvider<VisualEffect>
  {
    public override VisualEffect Get(object data = null)
    {
      var go = data as GameObject;
      return go.GetComponent<VisualEffect>();
    }
  }
}
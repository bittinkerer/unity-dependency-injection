using System.Linq;
using UnityEngine;
using UnityEngine.VFX;

namespace Packages.Esteny.Providers.VisualEffectsProviders
{
  internal class ArgTransformsFirstVisualEffectProvider : BaseProvider<VisualEffect>
  {
    public override VisualEffect Get(object data = null)
    {
      var transforms = data as Transform[];
      return transforms.First().gameObject.GetComponent<VisualEffect>();
    }
  }
}
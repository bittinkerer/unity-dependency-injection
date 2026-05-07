using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;
using System.Linq;

namespace Packages.Esteny.Providers.VisualEffectsProviders
{
  internal class ArgVisualEffectsProvider : BaseProvider<List<VisualEffect>>
  {
    public override List<VisualEffect> Get(object data = null) => data switch
    {
      List<GameObject> gos => gos.Select(go => go.GetComponent<VisualEffect>()).Where(x => x != null).ToList(),
      GameObject go => go.GetComponent<VisualEffect>() == null ? new List<VisualEffect>() : new List<VisualEffect> { go.GetComponent<VisualEffect>() },
      VisualEffect ve => new List<VisualEffect>{ve},
      List<VisualEffect> lve => lve,
      _ => new()
    };
    
  }
}
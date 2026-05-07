using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ParticleSystems
{
  internal class ArgTransformsToParticleSystemsProvider : BaseProvider<ParticleSystem[]>
  {
    public override ParticleSystem[] Get(object data = null)
    {
      if(data is not Transform[] transforms)
      {
        // @TODO: log error
        return null;
      }

      return transforms.Select(t => t.gameObject.GetComponent<ParticleSystem>()).ToArray();
    }
  }
}

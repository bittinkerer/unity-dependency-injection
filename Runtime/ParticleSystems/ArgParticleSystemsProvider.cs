using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Core.Extensions;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ParticleSystems
{
  internal class ArgParticleSystemsProvider : BaseParticleSystemsProvider
  {
    public override ParticleSystem[] Get(object data = null) => data switch
    {
      List<ParticleSystem> particleSystems => particleSystems.ToArray(),
      ParticleSystem particleSystem => new ParticleSystem[] { particleSystem },
      ParticleSystem[] pses => pses,
      GameObject go => 
        go.GetComponent<ParticleSystem>() == null 
        ? new ParticleSystem[0]
        : new ParticleSystem[] { go.GetComponent<ParticleSystem>() },
      List<GameObject> gos => GetParticleSystems(gos),
      Transform[] trs => 
        trs.SelectMany(tr => tr.gameObject.GetComponentInSelfAndChildren<ParticleSystem>()).ToArray(),
      _ => new ParticleSystem[0]
    };

    private ParticleSystem[] GetParticleSystems(List<GameObject> particleSystemGOs) =>
      particleSystemGOs
        .Where(go => go.GetComponent<ParticleSystem>() != null)
        .Select(go => go.GetComponent<ParticleSystem>())
        .ToArray() ?? new ParticleSystem[0];

  }
}
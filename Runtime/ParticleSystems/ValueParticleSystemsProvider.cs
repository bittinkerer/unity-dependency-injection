using UnityEngine;

namespace Assets.Scripts.Core.Providers.ParticleSystems
{
  internal class ValueParticleSystemsProvider : BaseProvider<ParticleSystem[]>
  {
    [SerializeField] private ParticleSystem[] _particleSystems;

    public override ParticleSystem[] Get(object data = null)
    {
      return _particleSystems;
    }
  }
}
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.RigidbodyProviders
{
  internal class ValueRigidbodiesProvider : BaseProvider<List<Rigidbody>>
  {
    [SerializeField] private List<Rigidbody> _bodies;   

    public override List<Rigidbody> Get(object data = null)
    {
      return _bodies;
    }
  }
} 
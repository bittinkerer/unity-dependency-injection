using UnityEngine;

namespace Assets.Scripts.Core.Providers.RigidbodyProviders
{
  internal class ValueRigidbodyProvider : BaseProvider<Rigidbody>
  {
    [SerializeField] private Rigidbody _body;

    public override Rigidbody Get(object data = null) => _body;
  }
}

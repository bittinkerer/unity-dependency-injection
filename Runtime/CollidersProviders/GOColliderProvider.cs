using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class GOColliderProvider : BaseProvider<Collider> {
    [SerializeField] private BaseProvider<GameObject> _goProvider;

    public override Collider Get(object data = null) => 
      _goProvider.Get(data).GetComponent<Collider>();
  }
}

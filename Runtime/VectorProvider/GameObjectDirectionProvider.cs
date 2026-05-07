using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class GameObjectDirectionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<GameObject> _goProvider;
    public override Vector3 Get(object data = null) => _goProvider.Get(data).transform.forward.normalized;
  }
}

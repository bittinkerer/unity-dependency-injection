using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class GameObjectBasePositionProvider : BasePositionProvider
  {
    [SerializeField] private GameObject _gameObject;

    public override Vector3 Get(object data = null)
    {
      return _gameObject.transform.position;
    }
  }
}

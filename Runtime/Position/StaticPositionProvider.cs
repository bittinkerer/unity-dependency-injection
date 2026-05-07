using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  public class StaticPositionProvider : BasePositionProvider
  {
    [SerializeField] private Vector3 _position;

    public override Vector3 Get(object data = null)
    {
      return _position;
    }
  }
}

using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class ThisOnEnablePositionProvider : BasePositionProvider
  {
    private Vector3 _position;

    private void OnEnable()
    {
      _position = this.transform.position;
    }

    public override Vector3 Get(object data = null)
    {
      return _position;
    }
  }
}

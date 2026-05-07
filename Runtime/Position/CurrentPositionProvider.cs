using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  public class CurrentPositionProvider : BasePositionProvider
  {
    public override Vector3 Get(object data = null)
    {
      return this.gameObject.transform.position;
    }
  }
}

using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class RootTransformProvider : BaseProvider<Transform>
  {
    public override Transform Get(object data = null) =>
      this.gameObject.GetRoot().transform;
    
  }
}

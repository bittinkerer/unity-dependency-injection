using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  internal class ForwardGlobalVectorProvider : BaseProvider<Vector3>
  {
    [SerializeField] private bool _reverse;

    public override Vector3 Get(object data = null) =>
      Vector3.forward * (_reverse ? -1 : 1);
    
  }
}

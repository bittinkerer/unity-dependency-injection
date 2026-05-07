using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  internal class ValueVector3Provider : BaseProvider<Vector3>
  {
    [SerializeField] private Vector3 _vectorValue;

    public override Vector3 Get(object data = null) =>
      _vectorValue;
  }
}
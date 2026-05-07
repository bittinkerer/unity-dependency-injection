using UnityEngine;

namespace Assets.Scripts.Core.Providers.QuaternionProviders
{
  internal class FromEulerAnglesQuaternionProvider : BaseProvider<Quaternion>
  {
    [SerializeField] private Vector3 _rotationInEulerAngles;

    public override Quaternion Get(object data = null) =>
      Quaternion.Euler(_rotationInEulerAngles.x, _rotationInEulerAngles.y, _rotationInEulerAngles.z);
  }
}

using UnityEngine;

namespace Packages.Esteny.Providers.QuaternionProviders
{
  internal class FromEulerAnglesQuaternionProvider : BaseProvider<Quaternion>
  {
    [SerializeField] private Vector3 _rotationInEulerAngles;

    public override Quaternion Get(object data = null) =>
      Quaternion.Euler(_rotationInEulerAngles.x, _rotationInEulerAngles.y, _rotationInEulerAngles.z);
  }
}

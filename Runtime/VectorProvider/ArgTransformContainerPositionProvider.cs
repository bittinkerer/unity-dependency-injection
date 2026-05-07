using System;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  internal class ArgTransformContainerPositionProvider : BaseProvider<Vector3>
  {
    public override Vector3 Get(object data = null) => data switch
    {
      GameObject go => go.transform.position,
      Collider co => co.transform.position,
      Component co => co.transform.position,
      _ => throw new NotImplementedException()
    };
  }
}

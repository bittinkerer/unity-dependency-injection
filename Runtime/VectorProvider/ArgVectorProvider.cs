using System;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class ArgVectorProvider : BaseProvider<Vector3>
  {
    public override Vector3 Get(object data = null) => data switch
    {
      Vector3 value => value,
      _ => throw new NotImplementedException()
    };
  }
}

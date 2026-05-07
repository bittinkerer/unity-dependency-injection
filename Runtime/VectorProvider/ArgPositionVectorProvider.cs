using System;
using System.Collections.Generic;
using System.Linq;
using Packages.Esteny.Providers.TransformProviders;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class ArgPositionVectorProvider : BaseProvider<Vector3>
  {
    public override Vector3 Get(object data = null) => data switch
    {
      Transform tr => tr.position,
      GameObject go => go.transform.position,
      Vector3 pos => pos,
      Transform[] trs => trs.First().position,
      Transforms ts => ts.First().position,
      List<Transform> ltr => ltr.First().position,
      _ => throw new NotImplementedException()
    };

  }
}

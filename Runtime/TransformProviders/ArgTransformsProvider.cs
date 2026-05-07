using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class ArgTransformsProvider : BaseProvider<Transform[]>
  {
    public override Transform[] Get(object data = null) =>
      data switch
      {
        Transform[] transforms => transforms,
        Transform transform => new Transform[] { transform },
        GameObject go => new Transform[] { go.transform},
        GameObject[] gos => gos.Select(g => g.transform).ToArray(),
        List<GameObject> gos => gos.Select(g => g.transform).ToArray(),
        _ => throw new NotImplementedException()
      };
  }
}
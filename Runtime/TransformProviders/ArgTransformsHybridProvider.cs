using System;
using System.Collections.Generic;
using System.Linq;
using Packages.Estenis.CoreCheckers_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class ArgTransformsHybridProvider : BaseProvider<Transforms>
  {
    public override Transforms Get(object data = null) => data switch
    {
      Transform tr => new Transforms(new Transform[] { tr }),
      Transform[] trs => new Transforms(trs),
      List<Transform> trs => new Transforms(trs),
      GameObject go => new Transforms(new Transform[] { go.transform }),
      GameObject[] gos => new Transforms( gos.Select(go => go.transform) ),
      CheckResult<List<Transform>> cr => new Transforms( (List<Transform>)cr.Value ),
      _ => throw new NotImplementedException()
    };
  }
}
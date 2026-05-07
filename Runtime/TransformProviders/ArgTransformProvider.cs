using System;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders
{
  internal class ArgTransformProvider : BaseProvider<Transform>
  {
    public override Transform Get(object data = null) =>
      data switch
      {
        Transform[] transforms => transforms.First(),
        Transform tr => tr,
        GameObject go => go.transform ,
        _ => throw new NotImplementedException()
      };
  }
}
using System;
using Packages.com.estenis.scriptableobjects_data.Runtime.Data;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders {
  internal class SODataTransformProvider : BaseProvider<Transforms> {
    [SerializeField] private TransformSOData _transformSOData;

    public override Transforms Get(object data = null) => _transformSOData.Data;
  }
}

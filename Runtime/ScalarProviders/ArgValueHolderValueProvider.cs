using System;
using Assets.Scripts.Core.Attributes;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders {
  internal class ArgValueHolderValueProvider : BaseProvider<int> {
    public override int Get(object data = null) => data switch {
      int i => i,
      ValueHolderAttribute vh => vh.Value,
      GameObject go => go.GetComponent<ValueHolderAttribute>().Value,
      _ => throw new NotSupportedException()
    };
  }
}

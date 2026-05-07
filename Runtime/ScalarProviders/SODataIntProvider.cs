using Packages.Estenis.ScriptableObjectsData_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.ScalarProviders {
  internal class SODataIntProvider : BaseProvider<int> {
    [SerializeField] private IntSOData _intData;

    public override int Get(object data = null) => _intData.Data;
  }
}

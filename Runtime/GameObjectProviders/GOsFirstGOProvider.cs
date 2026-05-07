using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class GOsFirstGOProvider : BaseProvider<GameObject> {
    [SerializeField] private BaseProvider<GameObjects> _gosProvider;

    public override GameObject Get(object data = null) => 
      _gosProvider.Get(data).First();
  }
}

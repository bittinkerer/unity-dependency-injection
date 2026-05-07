using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ValueGOsProvider : BaseProvider<GameObjects>
  {
    [SerializeField] private GameObject[] _gos;

    public override GameObjects Get(object data = null) => _gos;
  }
}

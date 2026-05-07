using System.Collections;
using System.Linq;
using Assets.Scripts.Core.Decorators;
using Assets.Scripts.Core.Traits;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders {
  internal class TraitGameObjectsProvider : BaseProvider<GameObjects> {
    [SerializeField] private TraitSO _trait;
    [Header("Optional")]
    [SerializeField] private BaseProvider<GameObjects> _rootGoForSearch;

    public override GameObjects Get(object data = null) {
      if (_rootGoForSearch != null) {
        GameObject root = _rootGoForSearch.Get(data);
        var gosWithTrait =
          root.GetComponentsInChildren<TraitCarrier>()
            .Where(tc => tc.Contains(_trait))
            .Select(tc => tc.gameObject);
        return new GameObjects(gosWithTrait);
      }
      else {
        var gosWithTraits = FindObjectsOfType<TraitCarrier>();
        var gosWithTrait = gosWithTraits.Where(tc => tc.Contains(_trait)).Select(tc => tc.gameObject);
        return new GameObjects(gosWithTrait);
      }
    }
  }
}

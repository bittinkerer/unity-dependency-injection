using System.Linq;
using Assets.Scripts.Core.Decorators;
using Assets.Scripts.Core.Traits;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.TransformProviders {
  internal class TraitTransformsProvider : BaseProvider<Transforms> {
    [SerializeField] private TraitSO _trait;

    public override Transforms Get(object data = null) =>
      Resources.FindObjectsOfTypeAll(typeof(GameObject))
        .Where(go =>
          ((GameObject)go).GetComponent<TraitCarrier>() != null
            && ((GameObject)go).GetComponent<TraitCarrier>().Contains(_trait))
        .Select(go => ((GameObject)go).transform)
        .FirstOrDefault();
  }
}

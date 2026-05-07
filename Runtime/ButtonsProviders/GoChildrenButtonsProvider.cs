using UnityEngine;
using UnityEngine.UI;

namespace Packages.Esteny.Providers.ButtonsProviders
{
  internal class GoChildrenButtonsProvider : BaseProvider<Buttons>
  {
    [SerializeField] private GameObject _parentGO;

    public override Buttons Get(object data = null) =>
      _parentGO.GetComponentsInChildren<Button>(includeInactive: false);
  }
}

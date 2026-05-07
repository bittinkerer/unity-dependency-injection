using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Core.Providers.ButtonsProviders
{
  internal class GoChildrenButtonsProvider : BaseProvider<Buttons>
  {
    [SerializeField] private GameObject _parentGO;

    public override Buttons Get(object data = null) =>
      _parentGO.GetComponentsInChildren<Button>(includeInactive: false);
  }
}

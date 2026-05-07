using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Core.Providers.ButtonsProviders
{
  internal class ValueButtonsProvider : BaseProvider<Buttons>
  {
    [SerializeField] private Button[] _button;

    public override Buttons Get(object data = null) => _button;
  }
}

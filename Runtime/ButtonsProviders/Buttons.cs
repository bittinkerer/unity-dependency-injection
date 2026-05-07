using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Assets.Scripts.Core.Providers.ButtonsProviders
{
  [Serializable]
  internal class Buttons : OneOrMany<Button> // OneOrMany<Button>
  {
    public Buttons(IEnumerable<Button> values) : base(values)
    {
    }

    // syntactic sugar
    public static implicit operator Buttons(Button value) => new(new Button[] { value });
    public static implicit operator Buttons(Button[] buttons) => new(buttons);
  }
}

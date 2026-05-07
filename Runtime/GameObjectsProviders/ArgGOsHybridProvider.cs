using System;
using Assets.Scripts.Core.Providers.GameObjectProviders;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectsProviders {
  internal class ArgGOsHybridProvider : BaseProvider<GameObjects> {

    public override GameObjects Get(object data = null) => data switch {
      GameObject[] gos => gos,
      GameObject go => new GameObjects(new  GameObject[] { go }),
      Component component => new GameObjects(new GameObject[] { component.gameObject }),
      _ => throw new NotSupportedException()
    };
  }
}
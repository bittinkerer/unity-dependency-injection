using System;
using UnityEngine;

//Packages.Estenis.EventActions_
namespace Packages.Esteny.Providers {
  internal class ArgGOsHybridProvider : BaseProvider<GameObjects> {

    public override GameObjects Get(object data = null) => data switch {
      GameObject[] gos => gos,
      GameObject go => new GameObjects(new  GameObject[] { go }),
      Component component => new GameObjects(new GameObject[] { component.gameObject }),
      _ => throw new NotSupportedException()
    };
  }
}
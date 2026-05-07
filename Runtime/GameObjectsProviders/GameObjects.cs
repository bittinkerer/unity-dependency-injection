using System.Collections.Generic;
using UnityEngine;

namespace Packages.Esteny.Providers
{
  internal class GameObjects : OneOrMany<GameObject>
  {
    public GameObjects(IEnumerable<GameObject> values) : base(values)
    {
    }

    // syntactic sugar
    public static implicit operator GameObjects(GameObject value) => new(new GameObject[] { value });
    public static implicit operator GameObjects(GameObject[] gos) => new(gos);
  }
}
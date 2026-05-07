using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Packages.Esteny.Providers.GameObjectsProviders {
  internal class ArgGameObjectsProvider : BaseProvider<List<GameObject>> {
    public override List<GameObject> Get(object data = null) => data switch {
      GameObject go => new List<GameObject> { go },
      List<GameObject> gos => gos,
      GameObject[] gos => gos.ToList(),
      Transform t => new List<GameObject> { t.gameObject },
      Transform[] ts => ts.Select(t => t.gameObject).ToList(),
      Component co => new List<GameObject> { co.gameObject },
      _ => new List<GameObject>()
    };
  }
}
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ArgFirstGoProvider : BaseProvider<GameObject>
  {
    public override GameObject Get(object data = null) =>
      data switch
      {
        GameObject[] gos => gos.First(),
        List<GameObject> gos => gos.First(),
        GameObject go => go,
        Transform[] ts => ts.First().gameObject,
        Component[] cs => cs.First().gameObject,
        Collider co => co.gameObject,
        _ => null
      };
  }
}
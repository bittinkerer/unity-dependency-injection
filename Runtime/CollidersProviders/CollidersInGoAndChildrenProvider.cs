using System.Linq;
using UnityEngine;

namespace Packages.Esteny.Providers.CollidersProviders
{
  internal class CollidersInGoAndChildrenProvider : BaseProvider<Collider[]>
  {
    [SerializeField] private GameObject _collidersGo;

    public override Collider[] Get(object data = null)
    {
      var localColls = _collidersGo.GetComponents<Collider>() ?? new Collider[0];
      var childrenColls = _collidersGo.GetComponentsInChildren<Collider>() ?? new Collider[0];
      return localColls.Union(childrenColls).ToArray();
    }

  }
}
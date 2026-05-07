using System;
using System.Linq;
using UnityEngine;

namespace Packages.Esteny.Providers.RigidbodyProviders {
  internal class ArgRigidbodiesProvider : BaseProvider<Rigidbodies> {
    public override Rigidbodies Get( object data = null ) => data switch {
      GameObject go => go.GetComponent<Rigidbody>(),
      GameObject[] gos => gos.Select( go => go.GetComponent<Rigidbody>() ).ToArray(),
      Transform tr => tr.gameObject.GetComponent<Rigidbody>(),
      Transform[] trs => trs.Select( tr => tr.gameObject.GetComponent<Rigidbody>() ).ToArray(),
      _ => throw new NotImplementedException()
    };
  }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Packages.Esteny.Providers
{
  [Serializable]
  internal class BoxColliders : IEnumerable<BoxCollider>
  {
    private BoxCollider[] _colliders;

    public BoxColliders(IEnumerable<BoxCollider> colliders)
    {
      if(colliders == null)
      {
        _colliders = new BoxCollider[0];
      }
      else
      {
        _colliders = colliders.ToArray();
      }
    }

    public IEnumerator<BoxCollider> GetEnumerator() =>
      ((IEnumerable<BoxCollider>)_colliders).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() =>
      _colliders.GetEnumerator();

    public static implicit operator BoxCollider(BoxColliders colliders) => colliders.FirstOrDefault();
    public static implicit operator BoxColliders(BoxCollider[] colliders) => new(colliders);
    public static implicit operator BoxColliders(BoxCollider collider) => new(new BoxCollider[] { collider });
  }
}

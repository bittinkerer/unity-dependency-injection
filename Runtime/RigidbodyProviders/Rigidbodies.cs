using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.RigidbodyProviders {
  internal class Rigidbodies : OneOrMany<Rigidbody> {
    public Rigidbodies( IEnumerable<Rigidbody> values ) : base( values ) {
    }

    // syntactic sugar
    public static implicit operator Rigidbodies( Rigidbody value ) => new( new Rigidbody[] { value } );
    public static implicit operator Rigidbodies( Rigidbody[] bodies ) => new( bodies );
  }
}

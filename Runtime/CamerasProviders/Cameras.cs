using System.Collections.Generic;
using UnityEngine;

namespace Packages.Esteny.Providers.CamerasProviders {
  internal class Cameras : OneOrMany<Camera> {
    public Cameras(IEnumerable<Camera> values) : base(values) { }

    // syntactic sugar
    public static implicit operator Cameras(Camera value) => new(new Camera[] { value });
    public static implicit operator Cameras(Camera[] cameras) => new(cameras);

  }
}

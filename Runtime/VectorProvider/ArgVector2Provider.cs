using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class ArgVector2Provider : BaseProvider<Vector2>
  {

    public override Vector2 Get(object data = null) => (Vector2)data;
  }
}
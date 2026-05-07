using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  internal class ArgVector2Provider : BaseProvider<Vector2>
  {

    public override Vector2 Get(object data = null) => (Vector2)data;
  }
}
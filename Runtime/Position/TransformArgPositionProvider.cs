using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class TransformArgPositionProvider : BasePositionProvider
  {
    public override Vector3 Get(object data = null)
    {
      Transform transform = data as Transform;
      if(transform == null)
      {
        if(data is GameObject gameObject)
        {
          return gameObject.transform.position;
        }

        //Debug.LogWarning($"Called {nameof(TransformArgPositionProvider)} with non-Transform arg");
        return Vector3.zero;
      }

      return transform.position;
    }
  }
}
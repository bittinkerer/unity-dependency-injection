using System;
using Assets.Scripts.Core.Decorators;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class GOWithTraitPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private TraitSO _trait;

    public override Vector3 Get(object data = null)
    {
      throw new NotImplementedException();
    }
  }
}

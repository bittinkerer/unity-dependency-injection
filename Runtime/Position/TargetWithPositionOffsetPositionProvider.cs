using Packages.Estenis.BoxPositionProviders_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class TargetWithPositionOffsetPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Vector3> _targetProvider;
    [SerializeField] private BasePositionProvider _positionEndingAtTargetProvider;
    [SerializeField] private BaseProvider<Transform> _transformToMoveProvider;

    public override Vector3 Get(object data = null)
    {
      var target = _targetProvider.Get(data);
      var transformToMove = _transformToMoveProvider.Get(data);
      var positionEndingUpOnTarget = _positionEndingAtTargetProvider.Get(data);

      var delta = target - positionEndingUpOnTarget;
      return transformToMove.position + delta;
    }
  }
}

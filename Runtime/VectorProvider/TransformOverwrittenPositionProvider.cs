using UnityEngine;

namespace Assets.Scripts.Core.Providers.VectorProvider
{
  /// <summary>
  /// Provides a position from a transform with possibly a subset of axis values overwritten
  /// while the rest remain from the original transform
  /// </summary>
  internal class TransformOverwrittenPositionProvider : BaseProvider<Vector3>
  {
    [SerializeField] private BaseProvider<Transform> _transformProvider;
    [SerializeField] private BaseProvider<Vector3> _overwritePositionProvider;
    [SerializeField] private bool _overwriteX = true;
    [SerializeField] private bool _overwriteY = true;
    [SerializeField] private bool _overwriteZ = true;

    public override Vector3 Get(object data = null)
    {
      var tr = _transformProvider.Get(data);
      var position = _overwritePositionProvider.Get(data);
      var positionOverwrite = new Vector3(
        _overwriteX ? position.x : tr.position.x,
        _overwriteY ? position.y : tr.position.y,
        _overwriteZ ? position.z : tr.position.z);
      return positionOverwrite;
    }
  }
}

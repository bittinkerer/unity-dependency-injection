using Packages.Estenis.BoxPositionProviders_;
using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.Position
{
  internal class GoNamePositionProvider : BasePositionProvider
  {
    [SerializeField] private string _goName;

    private GameObject _targetGO;
    private GameObject TargetGO => _targetGO != null
      ? _targetGO
      : (_targetGO = GameObject.Find(_goName));

    public override Vector3 Get(object data = null)
    {
      if(TargetGO == null) 
      {
        Debug.LogError($"{this.gameObject.GetRoot()}.{this.name}.{nameof(GoNamePositionProvider)} did NOT find GameObject with name [{_goName}]. Returning zero vector.");
        return Vector3.zero;
      }

      return TargetGO.transform.position;
    }
  }
}

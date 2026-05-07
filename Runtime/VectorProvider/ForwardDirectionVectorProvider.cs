using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider
{
  internal class ForwardDirectionVectorProvider : BaseVector3Provider
  {
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private bool _backwards = false;
    [SerializeField] private float _angleOffset = 0;
    [SerializeField] private bool _gizmosOn = false;


    public override Vector3 Get(object data) => _angleOffset switch
    {
      0 => _gameObject.transform.forward * (_backwards ? -1 : 1),
      _ => Quaternion.AngleAxis(_angleOffset, _gameObject.transform.right * (_backwards ? -1 : 1)) 
            * _gameObject.transform.forward * (_backwards ? -1 : 1)
    };

    private void OnDrawGizmos()
    {
      if (_gizmosOn)
      {
        var direction = Get(null);
        var target = _gameObject.transform.position + direction * 3;
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(_gameObject.transform.position, target);
      }
    }

  }
}
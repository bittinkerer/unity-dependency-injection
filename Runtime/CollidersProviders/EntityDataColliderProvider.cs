using Assets.Scripts.Core.Data;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class EntityDataColliderProvider : BaseProvider<Colliders> {
    [SerializeField] private EntityDataSO _entityData;
    [SerializeField] private string _dataKey;

    public override Colliders Get( object data = null ) {
      Collider collider = (Collider)_entityData.Retrieve((EventId, _dataKey));
      return collider;
    }
  }
}

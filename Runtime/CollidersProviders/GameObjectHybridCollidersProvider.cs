using System;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.CollidersProviders {
  internal class GameObjectHybridCollidersProvider : BaseProvider<Colliders> {
    [SerializeField] private BaseProvider<GameObject> _gameobjectProvider;

    public override Colliders Get(object data = null) => 
      new (new Collider[] { _gameobjectProvider.Get(data).GetComponent<Collider>() });
  }
}

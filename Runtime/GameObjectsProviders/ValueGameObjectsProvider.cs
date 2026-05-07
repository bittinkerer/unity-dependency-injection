using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectsProviders
{
  internal class ValueGameObjectsProvider : BaseProvider<List<GameObject>>
  {
    [SerializeField] private List<GameObject> _gameObjects;

    public override List<GameObject> Get(object data = null) => _gameObjects;
  }
}
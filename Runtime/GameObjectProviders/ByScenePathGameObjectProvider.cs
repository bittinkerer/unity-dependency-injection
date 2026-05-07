using UnityEngine;

namespace Assets.Scripts.Core.Providers.GameObjectProviders
{
  internal class ByScenePathGameObjectProvider : BaseProvider<GameObject>
  {
    [SerializeField] private string _goScenePath;

    public override GameObject Get(object data = null) => GameObject.Find(_goScenePath);
  }
}

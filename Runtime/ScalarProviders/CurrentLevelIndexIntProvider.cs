using UnityEngine.SceneManagement;

namespace Assets.Scripts.Core.Providers.ScalarProviders {
  internal class CurrentLevelIndexIntProvider : BaseProvider<int> {
    public override int Get(object data = null) =>
      SceneManager.GetActiveScene().buildIndex;
  }
}

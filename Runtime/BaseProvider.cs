using Packages.Estenis.GameEvent_;

namespace Assets.Scripts.Core.Providers
{
  public abstract class BaseProvider<T> : EventMonoBehaviour
  {
    public abstract T Get(object data = null);
  }
}
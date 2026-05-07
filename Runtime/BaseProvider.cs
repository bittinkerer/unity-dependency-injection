using UnityEngine;

namespace Packages.Esteny.Providers
{
  public abstract class BaseProvider<T> : MonoBehaviour
  {
    public abstract T Get(object data = null);
  }
}
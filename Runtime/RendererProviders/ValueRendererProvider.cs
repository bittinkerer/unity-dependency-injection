using UnityEngine;

namespace Packages.Esteny.Providers.RendererProviders
{
  internal class ValueRendererProvider : BaseProvider<Renderer>
  {
    [SerializeField] private Renderer _renderer;

    public override Renderer Get(object data = null) =>
      _renderer;
  }
}

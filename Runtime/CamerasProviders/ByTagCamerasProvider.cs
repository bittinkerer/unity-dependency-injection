using UnityEngine;

namespace Packages.Esteny.Providers.CamerasProviders {
  internal class ByTagCamerasProvider : BaseProvider<Cameras> {
    [SerializeField] private string _tag;

    public override Cameras Get(object data = null) => 
      GameObject.FindGameObjectWithTag(_tag).GetComponent<Camera>();
  }
}

using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  internal class ColliderBoundsSizeVectorProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Colliders> _collidersProvider;
    [SerializeField] private BaseProvider<Vector3>   _sizeFactorProvider;

    public override Vector3 Get( object data = null ) {
      Vector3 collBoundsSize = ((Collider)_collidersProvider.Get( data )).bounds.size;
      if ( _sizeFactorProvider != null ) {
        return collBoundsSize.HadaProduct( _sizeFactorProvider.Get( data ) );
      }
      return collBoundsSize;
    }
  }
}

using System;
using Packages.Estenis.UnityExts_;
using UnityEngine;

namespace Packages.Esteny.Providers.VectorProvider {
  public enum ColliderSideType {
    CENTER,
    BACK,
    FRONT,
    TOP,
    BOTTOM,
    TOPBACK,
    TOPFRONT,
    BOTTOMFRONT,
    BOTTOMBACK,
    QUARTER2TOPCENTER
  }

  /// <summary>
  /// Returns position on the bounds of the collider
  /// NOTE: that Right will always refer to its local-forward direction, similarly Top refers to local-up direction
  /// See picture of example bounds below and possible position provided 
  /// 
  /// (TB)------(T)--------(TF)         TB  = TopBack      
  ///  |                    |           T   = Top
  ///  |                    |           TF  = TopFront
  ///  |                    |           B   = Back
  /// (L)       (C)        (F) -->      C   = Center
  ///  |                    |           F   = Front (Aligned with Forward)
  ///  |                    |           TF  = TopFront
  /// (BB)______(B)________(BF)         F   = Front
  ///                                   BF  = BottomFront
  ///                                   BB  = BottomBack
  /// </summary>
  internal class CollidersPositionProvider : BaseProvider<Vector3> {
    [SerializeField] private BaseProvider<Colliders>  _collidersProvider;
    [SerializeField] private BaseProvider<Collider>   _colliderProvider;
    [SerializeField] private ColliderSideType         _colliderSide;

    public override Vector3 Get( object data = null ) {
      Collider collider =
        _collidersProvider != null
        ? _collidersProvider.Get(data)
        : _colliderProvider.Get(data) ;
      Transform tr            = this.gameObject.GetRoot().transform; // this should use a Provider
      Vector3 forwardLocal    = tr.forward;
      Vector3 upLocal         = tr.up;
      float collExtentsWidth  = collider.bounds.extents.z;
      float collExtentsHeight = collider.bounds.extents.y;
      
      return _colliderSide switch {
        ColliderSideType.CENTER           => collider.bounds.center,
        ColliderSideType.BACK             => collider.bounds.center - ( forwardLocal * collExtentsWidth ),
        ColliderSideType.FRONT            => collider.bounds.center + ( forwardLocal * collExtentsWidth ),
        ColliderSideType.TOP              => collider.bounds.center + ( upLocal * collExtentsHeight ),
        ColliderSideType.BOTTOM           => collider.bounds.center - ( upLocal * collExtentsHeight ),
        ColliderSideType.TOPBACK          => 
          collider.bounds.center
           - (forwardLocal *  collExtentsWidth)
           + (upLocal * collExtentsHeight),
        ColliderSideType.TOPFRONT         =>
          collider.bounds.center
           + ( forwardLocal * collExtentsWidth )
           + ( upLocal * collExtentsHeight ),
        ColliderSideType.BOTTOMFRONT      =>
          collider.bounds.center
           + ( forwardLocal * collExtentsWidth )
           - ( upLocal * collExtentsHeight ),
        ColliderSideType.BOTTOMBACK       =>
          collider.bounds.center 
          - ( forwardLocal * collExtentsWidth ) 
          - ( upLocal * collExtentsHeight ),
        ColliderSideType.QUARTER2TOPCENTER =>
          collider.bounds.center 
          + ( upLocal * collExtentsHeight / 2f ),
        _ => throw new NotSupportedException(),
      };
    }
  }
}
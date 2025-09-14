using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductPhoto
    : EntityBase
{
    public ProductPhoto()
    {
        #region Generated Constructor
        ProductProductPhotos = new HashSet<ProductProductPhoto>();
        #endregion
    }

    #region Generated Properties
    public int ProductPhotoID { get; set; }

    public byte[]? ThumbNailPhoto { get; set; }

    public string? ThumbnailPhotoFileName { get; set; }

    public byte[]? LargePhoto { get; set; }

    public string? LargePhotoFileName { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

    #endregion

}

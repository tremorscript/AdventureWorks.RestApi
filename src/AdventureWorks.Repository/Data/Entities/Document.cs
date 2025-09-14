using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Document
    : EntityBase
{
    public Document()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public short? DocumentLevel { get; set; }

    public string Title { get; set; } = null!;

    public int Owner { get; set; }

    public bool FolderFlag { get; set; }

    public string FileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public string Revision { get; set; } = null!;

    public int ChangeNumber { get; set; }

    public byte Status { get; set; }

    public string? DocumentSummary { get; set; }

    public byte[]? DocumentMember { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Employee OwnerEmployee { get; set; } = null!;

    #endregion

}

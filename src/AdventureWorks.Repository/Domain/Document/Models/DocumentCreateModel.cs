using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class DocumentCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'DocumentLevel'.
    /// </summary>
    /// <value>
    /// The property value for 'DocumentLevel'.
    /// </value>
    public short? DocumentLevel { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Title'.
    /// </summary>
    /// <value>
    /// The property value for 'Title'.
    /// </value>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Owner'.
    /// </summary>
    /// <value>
    /// The property value for 'Owner'.
    /// </value>
    public int Owner { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'FolderFlag'.
    /// </summary>
    /// <value>
    /// The property value for 'FolderFlag'.
    /// </value>
    public bool FolderFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'FileName'.
    /// </summary>
    /// <value>
    /// The property value for 'FileName'.
    /// </value>
    public string FileName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'FileExtension'.
    /// </summary>
    /// <value>
    /// The property value for 'FileExtension'.
    /// </value>
    public string FileExtension { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Revision'.
    /// </summary>
    /// <value>
    /// The property value for 'Revision'.
    /// </value>
    public string Revision { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ChangeNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'ChangeNumber'.
    /// </value>
    public int ChangeNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Status'.
    /// </summary>
    /// <value>
    /// The property value for 'Status'.
    /// </value>
    public byte Status { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DocumentSummary'.
    /// </summary>
    /// <value>
    /// The property value for 'DocumentSummary'.
    /// </value>
    public string? DocumentSummary { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DocumentMember'.
    /// </summary>
    /// <value>
    /// The property value for 'DocumentMember'.
    /// </value>
    public byte[]? DocumentMember { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Rowguid'.
    /// </summary>
    /// <value>
    /// The property value for 'Rowguid'.
    /// </value>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}

using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="DocumentCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<DocumentCreateModel>>]
public partial class DocumentCreateModelValidator
    : AbstractValidator<DocumentCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentCreateModelValidator"/> class.
    /// </summary>
    public DocumentCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Title).NotEmpty();
        RuleFor(p => p.Title).MaximumLength(50);
        RuleFor(p => p.FileName).NotEmpty();
        RuleFor(p => p.FileName).MaximumLength(400);
        RuleFor(p => p.FileExtension).NotEmpty();
        RuleFor(p => p.FileExtension).MaximumLength(8);
        RuleFor(p => p.Revision).NotEmpty();
        RuleFor(p => p.Revision).MaximumLength(5);
        #endregion
    }

}

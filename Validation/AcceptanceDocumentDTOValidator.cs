using AutoRepairShop.DTO;
using FluentValidation;

namespace AutoRepairShop.Validation;

public class AcceptanceDocumentDTOValidator : AbstractValidator<AcceptanceDocumentDTO>
{
    private string _requiredFieldMessage = "Поле {0} обязательно к заполнению";
    private string _maxLength = "Превышена максимальная длина поля";

    public AcceptanceDocumentDTOValidator()
    {
        RuleFor(dto => dto.CarUUID)
            .NotNull()
            .WithMessage(string.Format(_requiredFieldMessage, nameof(AcceptanceDocumentDTO.CarUUID)));

        RuleFor(dto => dto.CustomerUUID)
            .NotNull()
            .WithMessage(string.Format(_requiredFieldMessage, nameof(AcceptanceDocumentDTO.CustomerUUID)));

        RuleFor(dto => dto.Comment).MaximumLength(512).WithMessage(_maxLength);
    }
}

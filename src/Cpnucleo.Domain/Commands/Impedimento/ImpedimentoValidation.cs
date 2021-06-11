using FluentValidation;

namespace Cpnucleo.Domain.Commands.Impedimento
{
    public abstract class ImpedimentoValidation<T> : AbstractValidator<T> where T : ImpedimentoCommand
    {
    }
}

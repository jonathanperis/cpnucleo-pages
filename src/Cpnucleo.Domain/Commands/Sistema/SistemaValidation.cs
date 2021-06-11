using FluentValidation;

namespace Cpnucleo.Domain.Commands.Sistema
{
    public abstract class SistemaValidation<T> : AbstractValidator<T> where T : SistemaCommand
    {
    }
}

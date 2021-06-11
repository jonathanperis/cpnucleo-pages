using FluentValidation;

namespace Cpnucleo.Domain.Commands.Recurso
{
    public abstract class RecursoValidation<T> : AbstractValidator<T> where T : RecursoCommand
    {
    }
}

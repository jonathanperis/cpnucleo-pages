using FluentValidation;

namespace Cpnucleo.Domain.Commands.RecursoProjeto
{
    public abstract class RecursoProjetoValidation<T> : AbstractValidator<T> where T : RecursoProjetoCommand
    {
    }
}

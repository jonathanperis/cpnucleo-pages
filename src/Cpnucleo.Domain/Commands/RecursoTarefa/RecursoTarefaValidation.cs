using FluentValidation;

namespace Cpnucleo.Domain.Commands.RecursoTarefa
{
    public abstract class RecursoTarefaValidation<T> : AbstractValidator<T> where T : RecursoTarefaCommand
    {
    }
}

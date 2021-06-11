using FluentValidation;

namespace Cpnucleo.Domain.Commands.Tarefa
{
    public abstract class TarefaValidation<T> : AbstractValidator<T> where T : TarefaCommand
    {
    }
}

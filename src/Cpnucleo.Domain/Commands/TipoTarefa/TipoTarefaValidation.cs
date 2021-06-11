using FluentValidation;

namespace Cpnucleo.Domain.Commands.TipoTarefa
{
    public abstract class TipoTarefaValidation<T> : AbstractValidator<T> where T : TipoTarefaCommand
    {
    }
}

using FluentValidation;

namespace Cpnucleo.Domain.Commands.ImpedimentoTarefa
{
    public abstract class ImpedimentoTarefaValidation<T> : AbstractValidator<T> where T : ImpedimentoTarefaCommand
    {
    }
}

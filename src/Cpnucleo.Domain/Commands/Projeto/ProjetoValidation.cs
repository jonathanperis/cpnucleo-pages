using FluentValidation;

namespace Cpnucleo.Domain.Commands.Projeto
{
    public abstract class ProjetoValidation<T> : AbstractValidator<T> where T : ProjetoCommand
    {
    }
}

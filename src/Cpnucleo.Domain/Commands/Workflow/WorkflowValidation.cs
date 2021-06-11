using FluentValidation;

namespace Cpnucleo.Domain.Commands.Workflow
{
    public abstract class WorkflowValidation<T> : AbstractValidator<T> where T : WorkflowCommand
    {
    }
}

using Cpnucleo.Domain.Commands.Workflow.Validations;

namespace Cpnucleo.Domain.Commands.Workflow.Requests
{
    public class RemoveWorkflowCommand : WorkflowCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveWorkflowValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}

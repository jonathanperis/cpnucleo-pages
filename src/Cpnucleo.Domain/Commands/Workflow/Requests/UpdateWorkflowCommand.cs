using Cpnucleo.Domain.Commands.Workflow.Validations;

namespace Cpnucleo.Domain.Commands.Workflow.Requests
{
    public class UpdateWorkflowCommand : WorkflowCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateWorkflowValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}

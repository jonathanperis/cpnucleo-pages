using Cpnucleo.Domain.Commands.Workflow.Validations;

namespace Cpnucleo.Domain.Commands.Workflow.Requests
{
    public class CreateWorkflowCommand : WorkflowCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateWorkflowValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}

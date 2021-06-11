using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Workflow
{
    public abstract class WorkflowCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int? Ordem { get; set; }

        public string TamanhoColuna { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
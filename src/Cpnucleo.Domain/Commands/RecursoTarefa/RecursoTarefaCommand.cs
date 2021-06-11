using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.RecursoTarefa
{
    public abstract class RecursoTarefaCommand : Command
    {
        public Guid Id { get; set; }

        public int PercentualTarefa { get; set; }

        public Guid IdRecurso { get; set; }

        public Guid IdTarefa { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.ImpedimentoTarefa
{
    public abstract class ImpedimentoTarefaCommand : Command
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public Guid IdTarefa { get; set; }

        public Guid IdImpedimento { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
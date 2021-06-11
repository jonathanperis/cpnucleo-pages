using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Impedimento
{
    public abstract class ImpedimentoCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
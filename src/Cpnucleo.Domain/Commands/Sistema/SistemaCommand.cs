using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Sistema
{
    public abstract class SistemaCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
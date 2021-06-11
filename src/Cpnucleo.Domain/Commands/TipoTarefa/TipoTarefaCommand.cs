using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.TipoTarefa
{
    public abstract class TipoTarefaCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Image { get; set; }

        public string Element { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
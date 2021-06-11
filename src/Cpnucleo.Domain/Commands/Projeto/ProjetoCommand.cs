using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Projeto
{
    public abstract class ProjetoCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Guid IdSistema { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
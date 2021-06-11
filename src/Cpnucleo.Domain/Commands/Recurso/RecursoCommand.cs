using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Recurso
{
    public abstract class RecursoCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Salt { get; set; }

        public string Token { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
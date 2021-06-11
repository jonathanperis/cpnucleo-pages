using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.RecursoProjeto
{
    public abstract class RecursoProjetoCommand : Command
    {
        public Guid Id { get; set; }

        public Guid IdRecurso { get; set; }

        public Guid IdProjeto { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
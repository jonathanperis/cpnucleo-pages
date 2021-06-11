using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Apontamento
{
    public abstract class ApontamentoCommand : Command
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public DateTime? DataApontamento { get; set; }

        public int QtdHoras { get; set; }

        public Guid IdTarefa { get; set; }

        public Guid IdRecurso { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
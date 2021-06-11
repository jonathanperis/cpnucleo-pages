using NetDevPack.Messaging;
using System;

namespace Cpnucleo.Domain.Commands.Tarefa
{
    public abstract class TarefaCommand : Command
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int QtdHoras { get; set; }

        public string Detalhe { get; set; }

        public int HorasConsumidas { get; set; }

        public int HorasRestantes { get; set; }

        public Guid IdProjeto { get; set; }

        public Guid IdWorkflow { get; set; }

        public Guid IdRecurso { get; set; }

        public Guid IdTipoTarefa { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
using FluentValidation;
using System;

namespace Cpnucleo.Domain.Commands.Apontamento
{
    public abstract class ApontamentoValidation<T> : AbstractValidator<T> where T : ApontamentoCommand
    {
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateDescricao()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Necessário informar a descrição do Apontamento")
                .MaximumLength(150).WithMessage("Apontamento pode conter no máximo 150 caractéres");
        }

        protected void ValidateDataApontamento()
        {
            RuleFor(c => c.DataApontamento)
                .NotEmpty().WithMessage("Necessário informar a data do Apontamento")
                .Must(HaveDidToday)
                .WithMessage("Apontamento não pode ser lançado anterior ao dia atual");
        }

        protected void ValidateQtdHoras()
        {
            RuleFor(c => c.QtdHoras)
                .NotEmpty().WithMessage("Necessário informar a quantidade de horas do Apontamento")
                .InclusiveBetween(1, 24).WithMessage("Quantidade de horas do apontamento deve ser entre 1 e 24");
        }

        protected void ValidateIdTarefa()
        {
            RuleFor(c => c.IdTarefa)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateIdRecurso()
        {
            RuleFor(c => c.IdRecurso)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateDataInclusao()
        {
            RuleFor(c => c.DataInclusao)
                .NotEmpty().WithMessage("Necessário informar a data de inclusão do Apontamento")
                .Must(HaveNotDidToday)
                .WithMessage("Data de inclusão do apontamento não pode ser posterior ao dia atual");
        }

        protected static bool HaveDidToday(DateTime? dataApontamento)
        {
            return dataApontamento <= DateTime.Today;
        }

        protected static bool HaveNotDidToday(DateTime dataInclusao)
        {
            return dataInclusao >= DateTime.Today;
        }
    }
}

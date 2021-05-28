using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Cpnucleo.Infra.CrossCutting.Util.ViewModels
{
    [DataContract]
    public class ImpedimentoTarefaViewModel : BaseViewModel
    {
        [Key]
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public Guid Id { get; set; }

        [Display(Name = "Data de Inclusão")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataMember(Order = 2)]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Necessário informar a {0} do Impedimento.")]
        [MaxLength(450, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Tarefa")]
        public Guid IdTarefa { get; set; }

        [Required]
        [Display(Name = "Impedimento")]
        public Guid IdImpedimento { get; set; }

        public TarefaViewModel Tarefa { get; set; }

        public ImpedimentoViewModel Impedimento { get; set; }
    }
}
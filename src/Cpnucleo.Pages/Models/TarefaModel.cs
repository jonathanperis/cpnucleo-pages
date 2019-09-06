using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cpnucleo.Pages.Models
{
    [Table("CPN_TB_TAREFA")]
    public class TarefaModel //:IValidatableObject
    {
        [Key]
        [Display(Name = "Código Tarefa")]      
        [Column("TAR_ID", TypeName = "int")]
        public int IdTarefa { get; set; }

        [Display(Name = "Nome")]  
        [Required(ErrorMessage = "Necessário informar o {0} da Tarefa.")]
        [MaxLength(450, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")]    
        [Column("TAR_NOME", TypeName = "varchar(450)")]  
        public string Nome { get; set; }

        [Display(Name = "Data de Início")]      
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]        
        [Required(ErrorMessage = "Necessário informar a {0} da Tarefa.")]
        [Column("TAR_DATA_INICIO", TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }

        [Display(Name = "Data de Término")]      
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Necessário informar a {0} da Tarefa.")]
        [Column("TAR_DATA_TERMINO", TypeName = "datetime")]
        public DateTime? DataTermino { get; set; }

        [Display(Name = "Tempo Estimado")]      
        [Required(ErrorMessage = "Necessário informar o {0} da Tarefa.")]
        [Column("TAR_QTD_HORAS", TypeName = "int")]
        public int QtdHoras { get; set; }        

        [Display(Name = "Detalhe")]     
        [MaxLength(1000, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")] 
        [Column("TAR_DETALHE", TypeName = "varchar(1000)")]  
        public string Detalhe { get; set; }        

        [Display(Name = "Percentual Concluído")]      
        [Column("TAR_PERCENTUAL_CONCLUIDO", TypeName = "int")]
        public int? PercentualConcluido { get; set; }         

        [Display(Name = "Data de Inclusão")]      
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column("TAR_DATA_INCLUSAO", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }   

        [Display(Name = "Data de Alteração")]      
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column("TAR_DATA_ALTERACAO", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }        

        [Display(Name = "Projeto")]      
        [Column("PROJ_ID", TypeName = "int")]
        public int IdProjeto { get; set; }

        public ProjetoModel Projeto { get; set; }

        [Display(Name = "Workflow")]      
        [Column("WOR_ID", TypeName = "int")]
        public int? IdWorkflow { get; set; } 

        [Display(Name = "Recurso")]      
        [Column("REC_ID", TypeName = "int")]
        public int? IdRecurso { get; set; }         

        [Display(Name = "Tipo Tarefa")]      
        [Column("TIP_ID", TypeName = "int")]
        public int? IdTipoTarefa { get; set; }    

        [NotMapped]
        public int HorasConsumidas { get; set; }

        [NotMapped]
        public int HorasRestantes { get; set; }

        public WorkflowModel Workflow { get; set; }

        public RecursoModel Recurso { get; set; }

        public TipoTarefaModel TipoTarefa { get; set; }

        public List<ImpedimentoTarefaModel> ListaImpedimentos { get; set; }

        public List<ApontamentoModel> ListaApontamentos { get; set; }

        // public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        // {
        //     if (DataInicio < DateTime.Now.Date)
        //     {
        //         yield return new ValidationResult(
        //             "Data de Início não pode ser anterior a data atual.",
        //             new[] { "DataInicio" });                
        //     }

        //     if (DataTermino < DataInicio)
        //     {
        //         yield return new ValidationResult(
        //             "Data de Término não pode ser anterior a Data de Início.",
        //             new[] { "DataTermino" });                
        //     }
        // }
    }
}
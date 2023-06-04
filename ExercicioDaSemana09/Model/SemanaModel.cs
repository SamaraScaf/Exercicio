using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExercicioDaSemana09.Model
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime DataSemana { get; set; }
        [MaxLength(100)] public string Conteudo { get; set; }
        [Required] public bool AplicadoConteudo { get; set; }
    }
}
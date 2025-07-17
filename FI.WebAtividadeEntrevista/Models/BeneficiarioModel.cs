

using System.ComponentModel.DataAnnotations;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long Id { get; set; }
        /// <summary>
        /// CPF
        /// </summary>

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Digite um CPF válido")]
        public string CPF { get; set; }
        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage ="O tamanho do nome deve ter até 50 caracteres")]
        public string Nome { get; set; }

        /// <summary>
        /// IdCliente
        /// </summary>
        [Required]
        public int IdCliente { get; set; }
    }
}

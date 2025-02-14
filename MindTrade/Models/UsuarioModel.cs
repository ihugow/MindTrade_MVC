using MindTrade.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindTrade.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage ="Digite o nome.")]
        public string Nome { get; set; }
        [MaxLength(100)]

        [Required(ErrorMessage = "Digite o email.")]
        public string Email { get; set; }
        [MaxLength(50, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [MinLength(5, ErrorMessage = "O tamanho minimo é {1} caracteres")]

        [Required(ErrorMessage = "Digite a senha.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Escolha uma opção.")]
        public PerfilEnum Perfil { get; set; }

        [Required(ErrorMessage = "Selecione a data.")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Marque o campo.")]
        public bool Ativo {get; set; }
        public DateTime? DataInativacao { get; set; }

    }
}

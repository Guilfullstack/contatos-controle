using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class RedefinirSenhaModel 
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o email")]

        public string Email { get; set; }
        public RedefinirSenhaModel()
        {
            
        }

    }
}
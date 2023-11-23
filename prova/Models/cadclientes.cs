using System.ComponentModel.DataAnnotations;

namespace prova.Models
{
    public class cadclientes
    {
        [Key]
        public int idcliente { get; set; }
        public string nomecliente { get; set; }
        public string idade { get; set; }
        public string cpf { get; set; }
    }
}

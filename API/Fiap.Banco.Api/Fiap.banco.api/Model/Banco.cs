using System.ComponentModel.DataAnnotations;

namespace Fiap.banco.api.Model
{
    public class Banco
    {
        [Key]
        public int idBanco { get; set; }
        
        public string nomeBanco { get; set; }   

        public DateTime dtCriacao { get; set; } 

        public ICollection<Cliente>? Clientes { get; set; }
    }
}

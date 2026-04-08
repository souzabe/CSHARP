using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.banco.api.Model
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        
        public string nome { get; set; }

        [ForeignKey ("BancoId")]
        public Banco? Banco { get; set; }
    }
}

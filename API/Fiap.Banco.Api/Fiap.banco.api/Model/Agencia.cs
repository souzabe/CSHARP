using System.ComponentModel.DataAnnotations;

namespace Fiap.banco.api.Model
{
    public class Agencia
    {
        [Key]
        public int idAgencia {  get; set; }

        public string nmAgencia { get; set; }

        public string dsEndereco { get; set; }

    }
}

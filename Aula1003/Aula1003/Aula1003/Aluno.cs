using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace Aula1003
{
    public class Aluno
    {
        [JsonPropertyName("id")]
        public String rm { get; set; }
        
        [JsonPropertyName("nome")]
        public String nome { get; set; }
        
        [JsonPropertyName("cep")]
        public String cep { get; set;  }
        
        [JsonPropertyName("logradouro")]
        public String logradouro { get; set; }
        
        [JsonPropertyName("bairro")]
        public String bairro { get; set; }
        
        [JsonPropertyName("estado")]
        public String estado { get; set; }


    }
}

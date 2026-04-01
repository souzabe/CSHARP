using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Aula1003
{
    public class Usuario
    {
        [JsonPropertyName("name")]
        public String nome { get; set; }
        [JsonPropertyName("email")]
        public String email { get; set; }
        [JsonPropertyName("senha")]
        public String senha { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AlunoEndereco
    {
        [JsonPropertyName("logradouro")]
        public string RuaAluno { get; set; }

        [JsonPropertyName("bairro")]
        public String BairroAluno { get; set; }

        [JsonPropertyName("cep")]
        public string CepAluno { get; set; }
    }
}

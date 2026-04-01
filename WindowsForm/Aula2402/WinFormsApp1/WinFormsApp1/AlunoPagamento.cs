using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AlunoPagamento : Aluno
    {
        public int idPagamento { get; set; }
        public int idAluno { get; set; }
        private bool flMensalidadeDia { get;}

        public AlunoPagamento(bool _flMensalidadeDia)
        {
            this.flMensalidadeDia = _flMensalidadeDia;
        }
    }
}

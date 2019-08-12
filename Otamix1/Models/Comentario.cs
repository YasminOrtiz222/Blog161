using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Otamix1.Models
{
    public class Comentario
    {
        
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int MensagemId { get; set; }
        public int DescricaoId { get; set; }
        public int DataMensagenId { get; set; }
        public string Autor { get; set; }
        [ForeignKey("MensagemId")]
        public Mensagem Mensagem { get; set; }
        [ForeignKey("DescricaoId")]
        public Descricao Descricao { get; set; }


       
    }
}

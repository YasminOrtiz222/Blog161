using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otamix1.Models
{
    public class Mensagem
    {
      
        public int Id { get; set; }
        public string TItulo { get; set; }
        public string Descricao { get; set; }
        public string DataMensagem { get; set; }
        public string Categoria { get; set; }
           
    }
}

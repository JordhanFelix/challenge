using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models.Desafios
{
    public class DesafioViewModel
    {
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string ImgUrl { get; set; }
        public DateTime DataDeCriacao { get; set; }
    }
}

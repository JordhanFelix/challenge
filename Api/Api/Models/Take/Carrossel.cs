using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models.Take
{
    public class Carrossel
    {
        public string itemType { get; set; }
        public List<Header> items { get; set; }
    }
}

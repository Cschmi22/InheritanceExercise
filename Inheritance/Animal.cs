using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() 
        {
        }
        public bool SexualReproduction { get; set; }
        public bool Multicellular { get; set; }
        public bool Heterotrophic { get; set; }
        public string Motility { get; set; }
    }
}

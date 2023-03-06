using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        { 
            SexualReproduction= true;
            Multicellular = true;
            Heterotrophic= true;
            Motility = "Land and Water";
        }
        public bool ColdBlood { get; set; }
        public bool Scales { get; set; }
        public bool NoEars { get; set; }
        public int OptionalLimbs { get; set; }
    }
}

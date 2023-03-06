using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {
            SexualReproduction= true;
            Multicellular = true;
            Heterotrophic= true;
            Motility = "Air";
        }
        public bool Beaks { get; set; }
        public bool LightweightSkeleton { get; set; }
        public bool Wings { get; set; }
        public bool WarmBlood { get; set; }
    }
}

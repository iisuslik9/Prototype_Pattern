using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public enum WaterType
    {
        Freshwater,  
        Saltwater,   
    }
    public class Fish : Animal
    {
        public WaterType WaterType { get; set; }

    }
}

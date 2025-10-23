using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// класс Млекопитающее 
    /// потомок класса Animal
    /// добавляет свойство - температура тела
    /// </summary>
    public class Mammal : Animal, IMyCloneable<Mammal>
    {
        public double BodyTemperature { get; set; }
        public Mammal() { }


        public Mammal(int id, string name, int age, double bodyTemperature)
            : base(id, name, age)
        {
            BodyTemperature = bodyTemperature;
        }

        public Mammal(Mammal other) : base(other)
        {
            BodyTemperature = other.BodyTemperature;
        }

        public override Animal MyClone()
        {
            return new Mammal(this);
        }

        Mammal IMyCloneable<Mammal>.MyClone()
        {
            return new Mammal(this);
        }

    }
}

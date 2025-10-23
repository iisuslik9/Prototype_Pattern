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
    /// <summary>
    /// класс Рыба
    /// потомок класса Животное
    /// добавляет свойство ― тип воды (пресная/солёная)
    /// </summary>
    public class Fish : Animal, IMyCloneable<Fish>
    {
        public WaterType WaterType { get; set; }
        public Fish() { }

        public Fish(int id, string name, int age, WaterType waterType)
            : base(id, name, age)
        {
            WaterType = waterType;
        }
        public override string ToString()
        {
            return $"Fish: {Name}, Age: {Age}, Water: {WaterType}";
        }
        public Fish(Fish other) : base(other)
        {
            WaterType = other.WaterType;
        }
        public override Animal MyClone()
        {
            return new Fish(this);
        }

        Fish IMyCloneable<Fish>.MyClone()
        {
            return new Fish(this);
        }

        
    }
}

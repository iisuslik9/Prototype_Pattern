using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public enum WaterType
    {
        Fresh,  
        Salt,   
    }
    /// <summary>
    /// класс Рыба
    /// потомок класса Животное
    /// добавляет свойство ― тип воды (пресная/солёная)
    /// </summary>
    public class Fish : Animal, IMyCloneable<Animal>, ICloneable
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
        
        //поля базового класса копируются перед инициализацией полей производного
        public Fish(Fish other) : base(other)
        {
            WaterType = other.WaterType;
        }
       

        Animal IMyCloneable<Animal>.MyClone()
        {
            return new Fish(this);
        }

        object ICloneable.Clone()
        {
            return MyClone();
        }

    }
}

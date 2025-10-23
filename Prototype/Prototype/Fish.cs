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
    public class Fish : Animal
    {
        public WaterType WaterType { get; set; }
        public Fish() { }

        public Fish(int id, string name, int age, WaterType waterType)
            : base(id, name, age)
        {
            WaterType = waterType;
        }
    }
}

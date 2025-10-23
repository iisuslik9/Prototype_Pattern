using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// класс Собака
    /// потомок класса Animal
    /// добавляет свойство - порода
    /// </summary>
    public class Dog : Mammal
    {
        public string Breed { get; set; }
        
        public Dog() { }

        public Dog(int id, string name, int age, double bodyTemperature, string breed)
        : base(id, name, age, bodyTemperature) 
        {
            Breed = breed;
        }
    }
}

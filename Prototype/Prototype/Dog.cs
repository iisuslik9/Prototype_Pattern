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
    public class Dog : Mammal, IMyCloneable<Animal>, ICloneable
    {
        public string Breed { get; set; }
        
        public Dog() { }

        public Dog(int id, string name, int age, double bodyTemperature, string breed)
        : base(id, name, age, bodyTemperature) 
        {
            Breed = breed;
        }
        public override string ToString()
        {
            return $"Dog: {Name}, Age: {Age}, Temp: {BodyTemperature}, Breed: {Breed}";
        }

        //вызывает конструктор копир Mammal, который копирует поля Mammal
        //тот вызывает конструктор Animal, который копирует поля базового класса.
        protected Dog(Dog other) : base(other)
        {
            Breed = other.Breed;
        }


        Animal IMyCloneable<Animal>.MyClone()
        {
            return new Dog(this);
        }

        object ICloneable.Clone()
        {
            return MyClone();
        }

    }
}

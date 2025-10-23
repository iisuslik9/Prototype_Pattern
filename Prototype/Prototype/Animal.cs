using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Базовый класс Животное
    /// общие данные (id, имя, возраст)
    /// </summary>
    public class Animal : IMyCloneable<Animal>
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Animal() { }

        public Animal(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }


    }
}

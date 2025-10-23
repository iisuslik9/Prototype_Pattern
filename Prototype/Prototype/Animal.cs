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
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


    }
}

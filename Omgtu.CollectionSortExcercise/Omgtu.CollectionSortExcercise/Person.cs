using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omgtu.CollectionSortExcercise
{
    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Group { get; set; }

        /// <summary>
        /// Инициализирует пустого человека без имени
        /// </summary>
        public Person()
        {
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Group = string.Empty;
        }

        public Person(string surnameNameGroup)
        {
            string[] splittedStrings = surnameNameGroup.Split(' ');
            if (splittedStrings.Length !=3)
                throw new ArgumentException("Строка не соответствует шаблону");

            this.Surname = splittedStrings[0];
            this.Name = splittedStrings[1];
            this.Group = splittedStrings[2];
        }

        public string ToString()
        {
            return String.Format("{0} {1} {2}", this.Name, this.Surname, this.Group);
        }
    }
}

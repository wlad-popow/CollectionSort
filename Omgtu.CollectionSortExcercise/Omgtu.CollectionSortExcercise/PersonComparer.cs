using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omgtu.CollectionSortExcercise
{
    public static class PersonComparer 
    {
        public static int CompareByName(Person leftPerson, Person rightPerson)
        {
            if (leftPerson == null)
                if (rightPerson == null)
                    return 0;
                else
                    return -1;
            else
                return leftPerson.Name.CompareTo(rightPerson.Name);

        }

        public static int CompareBySurname(Person leftPerson, Person rightPerson)
        {
            //TODO: Добавить реализацию сравнения по именам
            return 0;
        }

        public static int CompareByGroupNameSurname(Person leftPerson, Person rightPerson)
        {
            //TODO: Добавить реализацию сравнения по именам
            return 0;
        }
    }
}

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
            //TODO: Добавить реализацию сравнения по именам

            return String.Compare(leftPerson.Name,rightPerson.Name);

            //throw new NotImplementedException();
        }

        public static int CompareBySurname(Person leftPerson, Person rightPerson)
        {
            //TODO: Добавить реализацию сравнения по именам

            return String.Compare(leftPerson.Surname,rightPerson.Surname);

            //throw new NotImplementedException();
        }

        public static int CompareByGroupNameSurname(Person leftPerson, Person rightPerson)
        {
            //TODO: Добавить реализацию сравнения по именам

            if (String.Compare(leftPerson.Group, rightPerson.Group) == 0)
            {
                if (CompareByName(leftPerson, rightPerson) == 0)
                {
                    return CompareBySurname(leftPerson, rightPerson);
                }
                else
                    return CompareByName(leftPerson, rightPerson);
            }
            else
                return String.Compare(leftPerson.Group,rightPerson.Group);

            //throw new NotImplementedException();
        }
    }
}

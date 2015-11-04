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
            if (leftPerson == null && rightPerson == null)
                return 0;

            if (leftPerson == null)
                return -1;

            if (rightPerson == null)
                return 1;

            return leftPerson.Name.CompareTo(rightPerson.Name);
        }

        public static int CompareBySurname(Person leftPerson, Person rightPerson)
        {
            if (leftPerson == null && rightPerson == null)
                return 0;

            if (leftPerson == null)
                return -1;

            if (rightPerson == null)
                return 1;

            return leftPerson.Surname.CompareTo(rightPerson.Surname);
        }

        public static int CompareByGroupNameSurname(Person leftPerson, Person rightPerson)
        {
            if (leftPerson == null && rightPerson == null)
                return 0;

            if (leftPerson == null)
                return -1;

            if (rightPerson == null)
                return 1;

            int resulCompareGroup = 
                leftPerson.Group.Substring(0,4).
                    CompareTo(rightPerson.Group.Substring(0,4));
            if (resulCompareGroup != 0)
                return resulCompareGroup;

            int resultCompareName = leftPerson.Name.CompareTo(rightPerson.Name);
            if (resultCompareName != 0)
                return resultCompareName;

            int resultCompareSurname = leftPerson.Surname.CompareTo(rightPerson.Surname);
            if (resultCompareSurname != 0)
                return resultCompareSurname;

            return 0;

        }
    }
}

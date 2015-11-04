using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omgtu.CollectionSortExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>();
            string fileFullPath = Path.GetFullPath(@"group.txt");

            if (!File.Exists(fileFullPath))
                throw new FileNotFoundException();

            string line;
            using (StreamReader file = new StreamReader(fileFullPath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Person student = new Person(line);
                    students.Add(student);
                }
            }

            students.Sort(PersonComparer.CompareByGroupNameSurname);

            foreach (Person student in students)
                Console.WriteLine(student);

            Console.ReadKey();
        }
    }
}

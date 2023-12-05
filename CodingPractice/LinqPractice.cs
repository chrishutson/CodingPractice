using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    //Work on sorting.  Linq sort and one where you write you own compare method.
    public class LinqPractice
    {
        List<Person> unsortedList = new List<Person>();
        public LinqPractice() {             
            
            unsortedList.Add(new Person { FirstName = "Han", LastName = "Solo", Age = 38 });
            unsortedList.Add(new Person { FirstName = "Anikin", LastName = "Skywalker", Age = 50 });            
            unsortedList.Add(new Person { FirstName = "Leia", LastName = "Organa", Age = 19 });
            unsortedList.Add(new Person { FirstName = "Lando", LastName = "Calrissian", Age = 40 });
            unsortedList.Add(new Person { FirstName = "Wicket", LastName = "Warick", Age = 8 });
            unsortedList.Add(new Person { FirstName = "Cassian", LastName = "Andor", Age = 32 });
            unsortedList.Add(new Person { FirstName = "Luke", LastName = "Skywalker", Age = 19 });
            unsortedList.Add(new Person { FirstName = "Sheev", LastName = "Palpatine", Age = 160 });

        }

        public List<Person> LinqSort() {
            List<Person> sortedList = unsortedList.OrderBy(x => x.LastName).ThenBy(x => x.Age).ToList();
            
            return sortedList;
        }

        //Sorting this way sorts the list in place.  It does not create a new list, so it's more 
        //memory efficient.
        public List<Person> BasicComparatorSort()
        {
            unsortedList.Sort(delegate (Person x, Person y)
            {
                return x.LastName.CompareTo(y.LastName);
            });

            return unsortedList;
        }

        //This is effectively the same as the LinqSort above.
        public List<Person> SortByTwoElements()
        {
            unsortedList.Sort(delegate (Person x, Person y)
            {
                int a = x.LastName.CompareTo(y.LastName);

                //If last names are the same, the above will return 0.  So sort by age.
                if (a == 0)
                {
                    a = x.Age.CompareTo(y.Age);
                }

                return a;
            });

            return unsortedList;            
        }

        public static void PrintList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " Age: " + person.Age);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}

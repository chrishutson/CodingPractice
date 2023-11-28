﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    //Work on sorting.  Linq sort and one where you write you own compare method.
    public class LinqPractice
    {
        List<Person> unsortedList = new List<Person>();
        public LinqPractice() { 
            
            unsortedList.Add(new Person { FirstName = "Lando", LastName = "Calrissian", Age = 40 });
            unsortedList.Add(new Person { FirstName = "Han", LastName = "Solo", Age = 38 });
            unsortedList.Add(new Person { FirstName = "Luke", LastName = "Skywalker", Age = 19 });
            unsortedList.Add(new Person { FirstName = "Leia", LastName = "Organa", Age = 19 });
            unsortedList.Add(new Person { FirstName = "Wicket", LastName = "Warick", Age = 8 });
            unsortedList.Add(new Person { FirstName = "Cassian", LastName = "Andor", Age = 32 });
            unsortedList.Add(new Person { FirstName = "Anikin", LastName = "Skywalker", Age = 50 });
            unsortedList.Add(new Person { FirstName = "Sheev", LastName = "Palpatine", Age = 160 });
        }

        public void LinqSort() {
            Console.WriteLine("Linq Sort");
        }

        public void ComparatorSort()
        {
            Console.WriteLine("Comparator Sort");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTaskHandson
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class LambdaExpression
    {
        public void LambdaMethod()
        {

            List<Dog> dogs = new List<Dog>()
            {
            new Dog { Name = "Nobita", Age = 3 },
            new Dog { Name = "Sinchen", Age = 1 },
            new Dog { Name = "misel", Age = 4 },
            };
            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine();


            //Using Lambda Expressions with Anonymous Types
            var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            foreach (var item in newDogsList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Sorting using a lambda expression
            var sortedDogs = dogs.OrderByDescending(x => x.Age);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
            }
        }
    }
}

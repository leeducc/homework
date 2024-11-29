using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.entity
{
    public abstract class Person
    {
        private static int lastId = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age} ");
        }

        protected Person()
        {
            Id = ++lastId;
        }
    }
}

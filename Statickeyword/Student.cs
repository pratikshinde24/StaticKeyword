using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statickeyword
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private static int count;

        static Student()
        {
            count = 0;
        }

        public Student( string name, int age)
        {
            count++;
            this.id = count;
            this.name = name;
            this.age = age;
        }

        public string display()
        {
           return $"Id={id}/Name={name}/age={ age} ";
        }
    }
}

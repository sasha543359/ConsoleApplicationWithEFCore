using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWithEFCore;

internal class Person
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
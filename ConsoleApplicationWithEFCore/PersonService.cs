﻿using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWithEFCore;

internal class PersonService
{
    public void AddPerson(string name, int age)
    {
        using (AppContext context = new AppContext())
        {
            context.Persons.Add(new Person(name, age));
            context.SaveChanges();
        }
    }

    public void RemovePerson(Guid id)
    {
        using (AppContext context = new AppContext())
        {
            var person = context.Persons.FirstOrDefault(x => x.Id == id);

            if(person != null)
            {
                context.Persons.Remove(person);
                context.SaveChanges();
            }
        }
    }

    public void UpdatePerson(Guid id, string name, int age)
    {
        using (AppContext context = new AppContext())
        {
            var person = context.Persons.FirstOrDefault(x => x.Id == id);

            person.Name = name;
            person.Age = age;

            context.Persons.Update(person);
            context.SaveChanges();
        }
    }

    public Person GetPersonById(Guid id)
    {
        using (AppContext context = new AppContext())
        {
            var person = context.Persons.FirstOrDefault(x => x.Id == id);

            return person;
        }
    }
}
using Azure;

namespace ConsoleApplicationWithEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonService personService = new PersonService();

            while (true)
            {
                Console.WriteLine("Выберите действие которое вы хотите совершить");

                Console.WriteLine("1. Добавить нового пользователя");

                Console.WriteLine("2. Обновить данные пользователя");

                Console.WriteLine("3. Найти пользователя");

                Console.WriteLine("4. Удалить пользователя");

                int value = int.Parse(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите имя");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите возраст");
                            int age = int.Parse(Console.ReadLine());

                            personService.AddPerson(name, age);
                        }
                        break;


                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите ID пользователя которого хотите обновить");
                            Guid guid = new Guid(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Введите новое имя");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите новый возраст");
                            int age = int.Parse(Console.ReadLine());

                            personService.UpdatePerson(guid, name, age);
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите ID пользователя которого хотите найти");
                            Guid guid = new Guid(Console.ReadLine());
                            Person person = personService.GetPersonById(guid);
                            Console.WriteLine($"Имя {person.Name}");
                            Console.WriteLine($"Возраст {person.Age}");

                            Thread.Sleep(3000);
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите ид пользователя которого хотите удалить");
                            Guid guid = new Guid(Console.ReadLine());
                            personService.RemovePerson(guid);
                        }
                        break;
                }

                Console.Clear();
            }
        }
    }
}
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokretanje
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoRepository repository = new TodoRepository();
            TodoItem item1 = new TodoItem("first");
            repository.Add(item1);
            foreach (TodoItem item in repository._inMemoryTodoDatabase)
            {
                Console.WriteLine(item.Id.ToString());
            }
            repository.Add(item1);
            foreach (TodoItem item in repository._inMemoryTodoDatabase)
            {
                Console.WriteLine(item.Id.ToString());
            }
            Console.WriteLine(repository.Get(item1.Id).Id);
            Console.ReadKey();
            repository.Add(item1);
            Console.ReadKey();

        }
    }
}

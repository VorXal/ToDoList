using System;
using ToDoList.Logic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Alex = new Owner(1,"Alex","Developer");
            Mission task = new Mission(1,"Work",new DateTime(2020,5,5),new DateTime(2080,5,5),Alex);

            Console.WriteLine(task.Name);
            Console.WriteLine(task.Owner.Name);
        }
    }
}

using System;
using System.Globalization;

namespace ToDoList.Logic
{
    public class Mission
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public TextInfo Info { get; set; }
        public DateTime CreateDate { get; private set; }
        public DateTime DeadlineDate { get; set; }
        public Owner Owner { get; private set; }

        public Mission(int id, string name, DateTime cd, DateTime dd, Owner owner)
        {
            if (id <= 0) throw new Exception("ID не может быть меньше или равно 0, id = " + id);
            if (name == null) throw new Exception("Имя не может быть пустым");
            if (cd > DateTime.Now) throw new Exception("Неверная дата создания задания");
            if (dd < DateTime.Now) throw new Exception("Заданию нужно время на выполнение");
            if (owner == null) throw new ArgumentNullException("У задания должен быть исполнитель");

            Id = id;
            Name = name;
            CreateDate = cd;
            DeadlineDate = dd;
            Owner = owner;
        }
    }
}

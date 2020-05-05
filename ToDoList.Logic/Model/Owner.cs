using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Logic
{
    public class Owner
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }

        public Owner(int id, string name, string role)
        {
            if (id <= 0) throw new Exception("ID не может быть меньше или равно 0, id = " + id);
            if (name == null) throw new ArgumentNullException("Имя не может быть пустым");
            if (role == null) throw new ArgumentNullException("У владельца отсутствует роль");

            Id = id;
            Name = name;
            Role = role;
        }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Models
{
    public class Manager
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        [MaxLength(12)]
        public string Password { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }

    }
}

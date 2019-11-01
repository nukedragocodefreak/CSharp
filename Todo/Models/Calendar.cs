using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Models
{
    public class Calendar

    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string SalesRep { get; set; }
        public string Description { get; set; }
        public string Availability { get; set; }
        public bool Done { get; set; }
        public string Approval { get; set; }
    }
}


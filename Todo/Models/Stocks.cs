using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Models
{
    public class Stocks
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Branchname { get; set; }
        public string Productname { get; set; }
        public string DDelivered { get; set; }
        public string Delivered { get; set; }
        public string Sold { get; set; }
        public string Instock { get; set; }
        public string Rate { get; set; }
    }
}

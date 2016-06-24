using System;
using SQLite;

namespace Master
{
    public class TODOItem
    {
        public TODOItem() { }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        
    }
}

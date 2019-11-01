using SQLite;

namespace Todo
{
	public class APhoto
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

    }
}


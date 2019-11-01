using SQLite;

namespace Todo
{
	public class Verify
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Passcode { get; set; }

	}
}


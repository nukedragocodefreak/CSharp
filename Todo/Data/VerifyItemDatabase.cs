using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Todo
{
	public class VerifyItemDatabase
	{
		readonly SQLiteAsyncConnection database;

		public VerifyItemDatabase(string dbPath)

		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Verify>().Wait();
		}

		public Task<List<Verify>> GetItemsAsync()
		{
			return database.Table<Verify>().ToListAsync();
		}

		public Task<List<Verify>> GetItemsNotDoneAsync(string veri)
		{
			return database.QueryAsync<Verify>("SELECT * FROM [Verify]");
		}

		public Task<Verify> GetItemAsync(int id)
		{
			return database.Table<Verify>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Verify item)
		{
			if (item.ID != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Verify item)
		{
			return database.DeleteAsync(item);
		}
	}
}


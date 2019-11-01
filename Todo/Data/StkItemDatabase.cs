using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Models;

namespace Todo
{
	public class StkItemDatabase
	{
		readonly SQLiteAsyncConnection database;

		public StkItemDatabase(string dbPath)


		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Stocks>().Wait();
		}

		public Task<List<Stocks>> GetItemsAsync()
		{
			return database.Table<Stocks>().ToListAsync();
		}

		public Task<List<Stocks>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Stocks>("SELECT * FROM [Stocks]");
		}

		public Task<Stocks> GetItemAsync(int id)
		{
			return database.Table<Stocks>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Stocks item)
		{
			if (item.Id != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Stocks item)
		{
			return database.DeleteAsync(item);
		}
	}
}


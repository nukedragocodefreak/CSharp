using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Models;

namespace Todo
{
	public class CusItemDatabase

	{
		readonly SQLiteAsyncConnection database;

		public CusItemDatabase(string dbPath)


		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Customer>().Wait();
		}

		public Task<List<Customer>> GetItemsAsync()
		{
			return database.Table<Customer>().ToListAsync();
		}

		public Task<List<Customer>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Customer>("SELECT * FROM [Customer]");
		}

		public Task<Customer> GetItemAsync(int id)
		{
			return database.Table<Customer>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Customer item)
		{
			if (item.Id != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Customer item)
		{
			return database.DeleteAsync(item);
		}
	}
}


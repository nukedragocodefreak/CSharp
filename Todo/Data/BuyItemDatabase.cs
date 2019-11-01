using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Models;

namespace Todo
{
	public class BuyItemDatabase
	{
		readonly SQLiteAsyncConnection database;

		public BuyItemDatabase(string dbPath)


		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Buyers>().Wait();
		}

		public Task<List<Buyers>> GetItemsAsync()
		{
			return database.Table<Buyers>().ToListAsync();
		}
        public Task<List<Register>> GetItemAsync1(string username, string password)
        {
            //return database.Table<Register>().Where(i => i.UserName == username && i.Password==password).FirstOrDefaultAsync();
            //
            return database.QueryAsync<Register>("SELECT * FROM [Buyers] WHERE UserName=? and Password =?", username, password);
        }
        public Task<List<Buyers>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Buyers>("SELECT Name FROM [Buyers]");
		}

		public Task<Buyers> GetItemAsync(int id)
		{
			return database.Table<Buyers>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Buyers item)
		{
			if (item.Id != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Buyers item)
		{
			return database.DeleteAsync(item);
		}
	}
}


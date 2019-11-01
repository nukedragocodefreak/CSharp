using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Models;

namespace Todo
{
	public class RegItemDatabase
	{
		readonly SQLiteAsyncConnection database;

		public RegItemDatabase(string dbPath)

		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Register>().Wait();
		}

		public Task<List<Register>> GetItemsAsync()
		{
			return database.Table<Register>().ToListAsync();
		}

		public Task<List<Register>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Register>("SELECT * FROM [Register]");
		}

		public Task<Register> GetItemAsync(int id)
		{
			return database.Table<Register>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}
        public Task<List<Register>> GetItemAsync1(string username, string password)
        {
            //return database.Table<Register>().Where(i => i.UserName == username && i.Password==password).FirstOrDefaultAsync();
            //
            return database.QueryAsync<Register>("SELECT * FROM [Register] WHERE UserName=? and Password =?", username, password);
        }

        public Task<int> SaveItemAsync(Register item)
		{
			if (item.Id != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Register item)
		{
			return database.DeleteAsync(item);
		}

	}
}


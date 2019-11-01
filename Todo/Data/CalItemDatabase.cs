using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Models;

namespace Todo
{
	public class CalItemDatabase
	{
		readonly SQLiteAsyncConnection database;

		public CalItemDatabase(string dbPath)



		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Calendar>().Wait();
		}

		public Task<List<Calendar>> GetItemsAsync()
		{
			//return database.Table<Calendar>().ToListAsync();
            return database.QueryAsync<Calendar>("SELECT * FROM [Calendar] WHERE Approval = 'Yes'");
		}
        public Task<List<Calendar>> GetItemsAsynca()
        {
            //return database.Table<Calendar>().ToListAsync();
            return database.QueryAsync<Calendar>("SELECT * FROM [Calendar]");
        }

        public Task<List<Calendar>> GetItemsAsync1()
        {
            //return database.Table<Calendar>().ToListAsync();
            return database.QueryAsync<Calendar>("SELECT * FROM [Calendar]");
        }
        public Task<List<Calendar>> GetItemsAsync2()
        {
            //return database.Table<Calendar>().ToListAsync();
            return database.QueryAsync<Calendar>("SELECT * FROM [Calendar] WHERE Approval = 'Yes' and Done = 1");
        }
        public Task<List<Calendar>> GetItemsAsync3()
        {
            //return database.Table<Calendar>().ToListAsync();
            return database.QueryAsync<Calendar>("SELECT * FROM [Calendar] WHERE Approval = 'Yes' and Done = 1  and Availability = 'Yes'");
        }

        public Task<List<Calendar>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Calendar>("SELECT * FROM [Calendar]");
		}

		public Task<Calendar> GetItemAsync(int id)
		{
			return database.Table<Calendar>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Calendar item)
		{
			if (item.ID != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Calendar item)
		{
			return database.DeleteAsync(item);
		}
	}
}


using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Todo
{
	public class PhotosItemDatabase
	{
		readonly SQLiteAsyncConnection database;

		public PhotosItemDatabase(string dbPath)

		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<APhoto>().Wait();
		}

		public Task<List<APhoto>> GetItemsAsync()
		{
			return database.Table<APhoto>().ToListAsync();
		}

		public Task<List<APhoto>> GetItemsNotDoneAsync(string veri)
		{
			return database.QueryAsync<APhoto>("SELECT * FROM [APhoto]");
		}

		public Task<APhoto> GetItemAsync(int id)
		{
			return database.Table<APhoto>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(APhoto item)
		{		
				return database.InsertAsync(item);
		}

		public Task<int> DeleteItemAsync(APhoto item)
		{
			return database.DeleteAsync(item);
		}
	}
}


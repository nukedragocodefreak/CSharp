using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Models;

namespace Todo
{
    public class ManItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ManItemDatabase(string dbPath)

        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Manager>().Wait();
        }

        public Task<List<Manager>> GetItemsAsync()
        {
            return database.Table<Manager>().ToListAsync();
        }

        public Task<List<Manager>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Manager>("SELECT * FROM [Manager]");
        }

        public Task<Manager> GetItemAsync(int id)
        {
            return database.Table<Manager>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        public Task<List<Manager>> GetItemAsync1(string username, string password)
        {
            //return database.Table<Manager>().Where(i => i.UserName == username && i.Password==password).FirstOrDefaultAsync();
            //
            return database.QueryAsync<Manager>("SELECT * FROM [Manager] WHERE UserName=? and Password =?", username, password);
        }

        public Task<int> SaveItemAsync(Manager item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Manager item)
        {
            return database.DeleteAsync(item);
        }

    }
}


using Contacts.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Repository
{
    public class Repository : IRepository
    {
        private Lazy<SQLiteAsyncConnection> _dataBase;
        public Repository()
        {
            _dataBase = new Lazy<SQLiteAsyncConnection>(() =>
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "contacts.db3");
                var database = new SQLiteAsyncConnection(path);
                database.CreateTableAsync<ProfileModel>();
                return database;

            });
        }
        public Task<int> DeleteAsync<T>(T enity) where T : IEntityBase, new()
        {
            return _dataBase.Value.DeleteAsync(enity);

        }

        public Task<List<T>> GetAllAsync<T>() where T : IEntityBase, new()
        {
            return _dataBase.Value.Table<T>().ToListAsync();
        }

        public Task<int> InsertAsync<T>(T enity) where T : IEntityBase, new()
        {
            return _dataBase.Value.InsertAsync(enity);
        }

        public Task<int> UpdateAsync<T>(T enity) where T : IEntityBase, new()
        {
            return _dataBase.Value.UpdateAsync(enity);
        }
    }
}

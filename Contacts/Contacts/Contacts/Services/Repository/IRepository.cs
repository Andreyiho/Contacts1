

using Contacts.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contacts.Services.Repository
{
    public interface IRepository
    {
        Task<int> InsertAsync<T>(T enity) where T : IEntityBase, new();
        Task<int> UpdateAsync<T>(T enity) where T : IEntityBase, new();
        Task<int> DeleteAsync<T>(T enity) where T : IEntityBase, new();
        Task<List<T>> GetAllAsync<T>() where T : IEntityBase, new();



    }
}

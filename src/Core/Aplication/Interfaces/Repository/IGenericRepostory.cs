using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces.Repository
{
    public interface IGenericRepostory<T> where T: BaseClass
    {
        Task<IEnumerable<T>> GetAllItemAsync();
        Task<T> GetItemAsync(int id);
        Task<bool> DeleteItemAsync(int id);
        Task<bool> AddItemAsync(T body);
        Task<T> UpdateItemAsync(int id);
    }
}

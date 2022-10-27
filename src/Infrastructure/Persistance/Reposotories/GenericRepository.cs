using Aplication.Interfaces.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Reposotories
{
    public class GenericRepository<T> : IGenericRepostory<T> where T : BaseClass
    {
        private AppliDbContext _context;

        public GenericRepository(AppliDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddItemAsync(T body)
        {
            if (body == null) return false;
            await _context.Set<T>().AddAsync(body);
            if (await _context.SaveChangesAsync() <= 0) return false;
            return true;
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            T Item= await _context.Set<T>().FindAsync(id);
            if (Item is null) return false;
             _context.Set<T>().Remove(Item);
            if (await _context.SaveChangesAsync() <= 0) return false;
            return true;

        }

        public async Task<IEnumerable<T>> GetAllItemAsync()
        {
            IEnumerable<T>list =  await _context.Set<T>().ToListAsync();
            return list;
        }

        public async Task<T> GetItemAsync(int id)
        {
            T Item = await _context.Set<T>().FindAsync(id);           
            return Item;
        }

        public async Task<T> UpdateItemAsync(int id)
        {
            T Item = await _context.Set<T>().FindAsync(id);
            return Item;
        }
    }
}

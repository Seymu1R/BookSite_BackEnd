using Aplication.Interfaces.Repository;
using Domain.Entities;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Reposotories
{
    public class BookReposotory:GenericRepository<Book>,Ibook
    {
        public BookReposotory(AppliDbContext context):base(context)
        {

        }
    }
}

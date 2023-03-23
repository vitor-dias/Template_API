using Domain.Adapters;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.InMemory.Repositories
{
    public class Repository : IRepository
    {
        public Task<IEnumerable<Domain.Entities.Repository>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Domain.Entities.Repository repo)
        {
            throw new NotImplementedException();
        }
    }
}

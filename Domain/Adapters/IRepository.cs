using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Adapters
{
    public interface IRepository
    {
        Task<IEnumerable<Repository>> GetAll();

        Task<int> Insert(Repository repo);
    }
}

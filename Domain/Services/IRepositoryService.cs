using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IRepositoryService
    {
        Task<IEnumerable<Repository>> RecoverAll();

        Task<int> Register(Repository club);
    }
}

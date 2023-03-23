using Domain.Adapters;
using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Service : IRepositoryService
    {
        private readonly IAdapter _adapter;
        private readonly IRepository _repository;

        public Service(IAdapter adapter, IRepository repository) =>
            (_adapter, _repository) = (adapter, repository);

        public async Task<IEnumerable<Repository>> RecoverAll()
        {
            var clubs = await _repository.GetAll();
            return clubs;
        }

        public async Task<int> Register(Repository repo)
        {
            var id = await _repository.Insert(repo);

            _ = _adapter.DoSomething();

            return id;
        }
    }
}

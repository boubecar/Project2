using Project_5S.Domain.Commands;
using Project_5S.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_5S.Domain.Handler
{
    public class DeleteEntityHandler<T> : IRequestHandler<DeleteEntityCommand<T>, string> where T : class
    {
        private readonly IRepository<T> repository;
        public DeleteEntityHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<string> Handle(DeleteEntityCommand<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Removeobject(request.Entity);
            return Task.FromResult(result);
        }
    }
}

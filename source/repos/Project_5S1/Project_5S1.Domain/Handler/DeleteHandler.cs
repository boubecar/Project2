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
    public class DeleteHandler<T> : IRequestHandler<DeleteCommand<T>, string> where T : class
    {
        private readonly IRepository<T> repository;
        public DeleteHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<string> Handle(DeleteCommand<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Remove(request.Id);
            return Task.FromResult(result);
        }

    }
}

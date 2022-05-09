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
   
    public class PutHandler<T> : IRequestHandler<PutCommand<T>, string> where T : class
    {
        private readonly IRepository<T> repository;
        public PutHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<string> Handle(PutCommand<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Update(request.Obj);
            return Task.FromResult(result);
        }
    }
}

using Project_5S.Domain.Interfaces;
using Project_5S.Domain.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_5S.Domain.Handler
{
    public class GetByIdHandler<T> : IRequestHandler<GetByIdQuery<T>, T> where T : class
    {

        private readonly IRepository<T> repository;
        public GetByIdHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<T> Handle(GetByIdQuery<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Get(request.Condition, request.Includes);
            return Task.FromResult(result);
        }
    }
}

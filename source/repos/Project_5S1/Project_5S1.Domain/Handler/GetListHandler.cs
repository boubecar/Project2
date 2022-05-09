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
   public class GetListHandler<T> : IRequestHandler<GetListQuery<T>, IEnumerable<T>> where T : class
    {
        private readonly IRepository<T> repository;

        public GetListHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<IEnumerable<T>> Handle(GetListQuery<T> request, CancellationToken cancellationToken)
        {
            var result = repository.GetList(request.Condition, request.Includes);
            return Task.FromResult(result);
        }

    }
}

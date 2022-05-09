using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5S.Domain.Commands
{
    public class DeleteEntityCommand<T> : IRequest<string> where T : class
    {
        public DeleteEntityCommand(T entity)
        {
            Entity = entity;
        }
        public T Entity { get; }

    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5S.Domain.Commands
{
    public class PostCommand<T> : IRequest<string> where T : class
    {
        public PostCommand(T obj)
        {
            Obj = obj;
        }
        public T Obj { get; }

    }
}

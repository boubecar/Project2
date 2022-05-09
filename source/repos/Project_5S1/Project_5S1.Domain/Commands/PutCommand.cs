using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5S.Domain.Commands
{
    public class PutCommand<T> : IRequest<string> where T : class
    {
        public PutCommand(T obj)
        {
            Obj = obj;
        }
        public T Obj { get; set; }
    }
}

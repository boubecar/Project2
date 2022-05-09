using Project_5S.Data.Context;
using Project_5S.Data.Repository;
using Project_5S.Domain.Commands;
using Project_5S.Domain.Handler;
using Project_5S.Domain.Interfaces;
using Project_5S.Domain.Models;
using Project_5S.Domain.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5S.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<Project_5SContext>();


            #region SaisieComment
            services.AddTransient<IRepository<Filiale>, Repository<Filiale>>();
            services.AddTransient<IRequestHandler<PostCommand<Filiale>, string>, PostHandler<Filiale>>();
            services.AddTransient<IRequestHandler<PutCommand<Filiale>, string>, PutHandler<Filiale>>();
            services.AddTransient<IRequestHandler<DeleteCommand<Filiale>, string>, DeleteHandler<Filiale>>();
            services.AddTransient<IRequestHandler<GetListQuery<Filiale>, IEnumerable<Filiale>>, GetListHandler<Filiale>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<Filiale>, Filiale>, GetByIdHandler<Filiale>>();

            #endregion
            #region SaisieComment1
            services.AddTransient<IRepository<Pole>, Repository<Pole>>();
            services.AddTransient<IRequestHandler<PostCommand<Pole>, string>, PostHandler<Pole>>();
            services.AddTransient<IRequestHandler<PutCommand<Pole>, string>, PutHandler<Pole>>();
            services.AddTransient<IRequestHandler<DeleteCommand<Pole>, string>, DeleteHandler<Pole>>();
            services.AddTransient<IRequestHandler<GetListQuery<Pole>, IEnumerable<Pole>>, GetListHandler<Pole>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<Pole>, Pole>, GetByIdHandler<Pole>>();
            #endregion
            services.AddTransient<IRepository<criteres>, Repository<criteres>>();
            services.AddTransient<IRequestHandler<PostCommand<criteres>, string>, PostHandler<criteres>>();
            services.AddTransient<IRequestHandler<PutCommand<criteres>, string>, PutHandler<criteres>>();
            services.AddTransient<IRequestHandler<DeleteCommand<criteres>, string>, DeleteHandler<criteres>>();
            services.AddTransient<IRequestHandler<GetListQuery<criteres>, IEnumerable<criteres>>, GetListHandler<criteres>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<criteres>, criteres>, GetByIdHandler<criteres>>();


            services.AddTransient<IRepository<FilLocal>, Repository<FilLocal>>();
            services.AddTransient<IRequestHandler<PostCommand<FilLocal>, string>, PostHandler<FilLocal>>();
            services.AddTransient<IRequestHandler<PutCommand<FilLocal>, string>, PutHandler<FilLocal>>();
            services.AddTransient<IRequestHandler<DeleteCommand<FilLocal>, string>, DeleteHandler<FilLocal>>();
            services.AddTransient<IRequestHandler<GetListQuery<FilLocal>, IEnumerable<FilLocal>>, GetListHandler<FilLocal>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<FilLocal>, FilLocal>, GetByIdHandler<FilLocal>>();


            services.AddTransient<IRepository<Normes>, Repository<Normes>>();
            services.AddTransient<IRequestHandler<PostCommand<Normes>, string>, PostHandler<Normes>>();
            services.AddTransient<IRequestHandler<PutCommand<Normes>, string>, PutHandler<Normes>>();
            services.AddTransient<IRequestHandler<DeleteCommand<Normes>, string>, DeleteHandler<Normes>>();
            services.AddTransient<IRequestHandler<GetListQuery<Normes>, IEnumerable<Normes>>, GetListHandler<Normes>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<Normes>, Normes>, GetByIdHandler<Normes>>();

            services.AddTransient<IRepository<notation>, Repository<notation>>();
            services.AddTransient<IRequestHandler<PostCommand<notation>, string>, PostHandler<notation>>();
            services.AddTransient<IRequestHandler<PutCommand<notation>, string>, PutHandler<notation>>();
            services.AddTransient<IRequestHandler<DeleteCommand<notation>, string>, DeleteHandler<notation>>();
            services.AddTransient<IRequestHandler<GetListQuery<notation>, IEnumerable<notation>>, GetListHandler<notation>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<notation>, notation>, GetByIdHandler<notation>>();

            services.AddTransient<IRepository<plan_action>, Repository<plan_action>>();
            services.AddTransient<IRequestHandler<PostCommand<plan_action>, string>, PostHandler<plan_action>>();
            services.AddTransient<IRequestHandler<PutCommand<plan_action>, string>, PutHandler<plan_action>>();
            services.AddTransient<IRequestHandler<DeleteCommand<plan_action>, string>, DeleteHandler<plan_action>>();
            services.AddTransient<IRequestHandler<GetListQuery<plan_action>, IEnumerable<plan_action>>, GetListHandler<plan_action>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<plan_action>, plan_action>, GetByIdHandler<plan_action>>();

            services.AddTransient<IRepository<Users>, Repository<Users>>();
            services.AddTransient<IRequestHandler<PostCommand<Users>, string>, PostHandler<Users>>();
            services.AddTransient<IRequestHandler<PutCommand<Users>, string>, PutHandler<Users>>();
            services.AddTransient<IRequestHandler<DeleteCommand<Users>, string>, DeleteHandler<Users>>();
            services.AddTransient<IRequestHandler<GetListQuery<Users>, IEnumerable<Users>>, GetListHandler<Users>>();
            services.AddTransient<IRequestHandler<GetByIdQuery<Users>, Users>, GetByIdHandler<Users>>();

        }
    }
}

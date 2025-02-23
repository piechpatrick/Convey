﻿using System.Threading.Tasks;
using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Convey.CQRS.Queries;

namespace Convey.WebApi.CQRS
{
    public interface IDispatcher
    {
        Task SendAsync<T>(T command) where T : class, ICommand;
        Task PublishAsync<T>(T @event) where T : class, IEvent;
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}
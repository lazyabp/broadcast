using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;

namespace Lazy.Abp.BroadcastKit
{
    public class BroadcastManager : DomainService, ITransientDependency
    {
        private readonly IBroadcastRepository _repository;

        public BroadcastManager(IBroadcastRepository repository)
        {
            _repository = repository;
        }
    }
}

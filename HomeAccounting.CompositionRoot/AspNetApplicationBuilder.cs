using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.DataSource;
using HomeAccounting.DataSource.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection services) : base(services)
        {
        }

        protected override void RegisterBusinessLogic()
        {
            _services.AddTransient<IAccounting, AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            _services.AddTransient<IRepository, RepositoryBasePostgre>();
        }

        protected override void RegisterInfrastructure()
        {
            
        }
    }
}

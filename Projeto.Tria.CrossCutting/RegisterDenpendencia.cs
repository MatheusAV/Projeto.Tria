using Microsoft.Extensions.DependencyInjection;
using Projeto.Tria.Infra.Ropositories;
using Projeto.Tria.Infra.Ropositories.Interface;
using Projeto.Tria.Services.Interfaces;
using Projeto.Tria.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Tria.CrossCutting
{
    public class RegisterDenpendencia
    {
        private static IServiceCollection _serviceDescriptors { get; set; }
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            _serviceDescriptors = services;

        }

        public static TService GetService<TService>()
        {
            return (TService)_serviceDescriptors.FirstOrDefault().ImplementationInstance;
        }
    }
}

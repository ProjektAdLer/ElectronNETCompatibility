using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ElectronWrapper
{

    class ServiceCollectionExtensionsWrapper : IServiceCollectionExtensionsWrapper
    {
        /// <summary>
        /// Adds the <see cref="Electron"/> Members to the Service Collection
        /// </summary>
        public IServiceCollection AddElectron(IServiceCollection services)
        {
            return ServiceCollectionExtensions.AddElectron(services);
        }
    }
}

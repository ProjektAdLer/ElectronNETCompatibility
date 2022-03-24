using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;

namespace ElectronWrapper
{
    interface IMenuWrapperFactory
    {
        MenuWrapper Create();
    }
    class MenuWrapperFactory: IMenuWrapperFactory
    {

        public MenuWrapper Create()
        {
            return new MenuWrapper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IWindowManagerWraperFactory
{
    ElectronWrapper.WindowManagerWraper Create();
}

namespace ElectronWrapper
{
    class WindowManagerWraperFactory : IWindowManagerWraperFactory
    {

        public WindowManagerWraper Create() { return new WindowManagerWraper(); }
    }
}

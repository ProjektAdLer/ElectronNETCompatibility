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

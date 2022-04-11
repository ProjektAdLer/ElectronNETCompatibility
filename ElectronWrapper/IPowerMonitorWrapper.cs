using System;

namespace ElectronWrapper;

interface IPowerMonitorWrapper
{
    event Action OnAC;
    event Action OnBattery;
    event Action OnLockScreen;
    event Action OnResume;
    event Action OnShutdown;
    event Action OnSuspend;
    event Action OnUnLockScreen;
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
namespace ElectronWrapper
{
    /// <summary>
    /// Event arguments for the <see cref="App.BeforeQuit"/> / <see cref="App.WillQuit"/> event.
    /// </summary>
    class QuitEventArgsWrapper : IQuitEventArgsWrapper
    {
        private QuitEventArgs quitEventArgs;
        /// <summary>
        /// Will prevent the default behaviour, which is terminating the application.
        /// </summary>
        public void PreventDefault()
        {
            quitEventArgs.PreventDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;

namespace ElectronWrapper
{
    class BridgeSettingsWrapper : IBridgeSettingsWrapper
    {
        /// <summary>
        /// Gets the socket port.
        /// </summary>
        /// <value>
        /// The socket port.
        /// </value>
        public string SocketPort { get { return BridgeSettings.SocketPort; } }

        /// <summary>
        /// Gets the web port.
        /// </summary>
        /// <value>
        /// The web port.
        /// </value>
        public static string WebPort { get { return BridgeSettings.WebPort; } }
    }
}

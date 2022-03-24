using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
namespace ElectronWrapper
{
    class HybridSupportWrapper : IHybridSupportWrapper
    {
        /// <summary>
        /// Gets a value indicating whether this instance is electron active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is electron active; otherwise, <c>false</c>.
        /// </value>
        public bool IsElectronActive
        {
            get
            {
                return HybridSupport.IsElectronActive;
            }
        }
    }
}

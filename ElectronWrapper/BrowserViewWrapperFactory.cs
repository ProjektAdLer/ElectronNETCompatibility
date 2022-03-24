using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;

namespace ElectronWrapper
{
	class BrowserViewWrapperFactory
	{
		public Task<BrowserViewWrapper> Create()
		{
//Lässt sich ohne Zugriff auf den Internal Konstruktor nur über den Umweg über den WindowManager erstellen, was nicht einfach so funktioniert hat.
			return null;
		}
	}
}

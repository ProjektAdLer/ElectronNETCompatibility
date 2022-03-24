using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;

namespace ElectronWrapper
{
	public interface IBrowserViewWrapper
	{
		int Id { get; }
		WebContents WebContents { get; }
		Rectangle Bounds { get; set; }
		void SetAutoResize(AutoResizeOptions options);
		void SetBackgroundColor(string color);
	}
}

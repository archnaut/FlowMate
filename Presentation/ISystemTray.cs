using System;
using System.Collections.Generic;
using System.Drawing;
using Hardcodet.Wpf.TaskbarNotification;

namespace Presentation
{
	public interface ISystemTray
	{
		void Add(Icon icon);
	}
}

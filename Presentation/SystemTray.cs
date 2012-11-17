using System;
using System.Collections.Generic;
using System.Drawing;
using Hardcodet.Wpf.TaskbarNotification;

namespace Presentation
{
	public class SystemTray : ISystemTray
	{
		private IList<TaskbarIcon> _trayIcons;
		
		public SystemTray():this(new List<TaskbarIcon>()){}
		
		internal SystemTray(IList<TaskbarIcon> trayIcons){
			_trayIcons = trayIcons;
		}
		
		public void Add(Icon icon)
		{
			_trayIcons.Add(new TaskbarIcon{Icon = icon});
		}
	}
}

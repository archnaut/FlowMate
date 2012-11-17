using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NUnit.Framework;
using Presentation;
using Hardcodet.Wpf.TaskbarNotification;

namespace Testing.Presentation
{
	public class WhenIconIsAddedToSystemTray
	{
		[Test]
		public void ShouldCreateTaskbarIcon()
		{
			// Arrange
			var icon = new Icon(FlowMate.TrayIconFileName);
			var trayIcons = new List<TaskbarIcon>();
			var systemTray = new SystemTray(trayIcons);
			
			// Act
			systemTray.Add(icon);
			
			// Assert
			Assert.AreEqual(icon, trayIcons.FirstOrDefault().Icon);
		}
	}
}

using System;
using System.Drawing;
using System.IO;
using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;

namespace Presentation
{
	public class Program
	{

		[STAThread]
		public static void Main(){
			var flowMate = new FlowMate();
			flowMate.Run();
		}
	}
}

using System;
using System.Windows;

namespace Presentation
{
	public class ApplicationAdapter : IApplication
	{
		private Application _application = new Application();
		
		public void Run()
		{
			_application.Run();
		}
	}
}

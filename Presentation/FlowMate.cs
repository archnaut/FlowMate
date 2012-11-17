using System;

namespace Presentation
{
	public class FlowMate
	{
		internal const string TrayIconFileName = "./resources/images/StopWatch.ico";
		
		private IApplication _application;
		private IResourceService _resourceService;
		private ISystemTray _systemTray;
		
		public FlowMate():this(new ApplicationAdapter(), new ResourceService(), new SystemTray()){}
		
		internal FlowMate(IApplication application, IResourceService resourceService, ISystemTray systemTray)
		{
			_resourceService = resourceService;
			_systemTray = systemTray;
			_application = application;
		}
		
		public void Run()
		{
			_systemTray.Add(_resourceService.LoadIcon(TrayIconFileName));
			_application.Run();
		}
	}
}

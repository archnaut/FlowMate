using System;
using System.Drawing;
using NUnit.Framework;
using Rhino.Mocks;
using Presentation;

namespace Testing.Presentation
{
	public class WhenFlowMateIsRun
	{
		private IApplication _application;
		private ISystemTray _systemTray;
		private Icon _trayIcon = new Icon(FlowMate.TrayIconFileName);
		
		[SetUp]
		public void SetUp()
		{
			var resourceServcie = MockRepository.GenerateStub<IResourceService>();
			resourceServcie.Stub(x=>x.LoadIcon(FlowMate.TrayIconFileName)).Return(_trayIcon);
			
			_application = MockRepository.GenerateStub<IApplication>();
			_systemTray = MockRepository.GenerateStub<ISystemTray>();
			var flowMate = new FlowMate(_application, resourceServcie, _systemTray);
			
			flowMate.Run();
			
		}
		
		[Test]
		public void ShouldAddIconToSystemTray()
		{
			_systemTray.AssertWasCalled(x=>x.Add(_trayIcon));
		}
		
		[Test]
		public void ShouldRunApplication()
		{
			_application.AssertWasCalled(x=>x.Run());
		}
	}
}

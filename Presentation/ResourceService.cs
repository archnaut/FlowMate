using System;
using System.Drawing;

namespace Presentation
{
	public class ResourceService : IResourceService
	{
		public Icon LoadIcon(string fileName)
		{
			return new Icon(fileName);
		}
	}
}

using System;
using System.Drawing;

namespace Presentation
{
	public interface IResourceService
	{
		Icon LoadIcon(string fileName);
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCustomizationSample.Services
{
	public interface IDeviceOrientationService
	{
		DeviceOrientation GetDeviceOrientation();
	}

	public enum DeviceOrientation
	{
		Landscape,
		Portrait
	}
}

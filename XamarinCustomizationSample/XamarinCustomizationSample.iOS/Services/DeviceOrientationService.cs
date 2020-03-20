using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinCustomizationSample.iOS.Services;
using XamarinCustomizationSample.Services;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace XamarinCustomizationSample.iOS.Services
{
	public class DeviceOrientationService : IDeviceOrientationService
	{
		DeviceOrientation IDeviceOrientationService.GetDeviceOrientation()
		{
			var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;
			bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

			return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
		}
	}
}
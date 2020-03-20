using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCustomizationSample.Services;

namespace XamarinCustomizationSample.ViewModels
{
	public class MainPageViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;
		public string CurrentDeviceOrientation { get; set; } = "";

		public ICommand GetDeviceOrientationCommand { get; set; }

		public MainPageViewModel()
		{
			this.GetDeviceOrientation();
			this.GetDeviceOrientationCommand = new Command(GetDeviceOrientation);
		}

		public void GetDeviceOrientation()
		{
			this.CurrentDeviceOrientation = DependencyService.Get<IDeviceOrientationService>().GetDeviceOrientation() == DeviceOrientation.Landscape ? "Landscape" : "Portrait";

		}
	}
}

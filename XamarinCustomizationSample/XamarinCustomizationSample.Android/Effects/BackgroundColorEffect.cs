using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinCustomizationSample.Droid.Effects;
using XamarinCustomizationSample.Effects;

[assembly: ResolutionGroupName("XamarinCustomizationSample")]
[assembly: ExportEffect(typeof(AndroidBackgroundColorEffect),"BackgroundColorEffect")]
namespace XamarinCustomizationSample.Droid.Effects
{
	public class AndroidBackgroundColorEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			if(Control != null)
			{
				var element = (BackgroundColorEffect)Element.Effects.FirstOrDefault(e => e is BackgroundColorEffect);
				Control.SetBackgroundColor(element.BackgroundColor.ToAndroid());
			}
		}

		protected override void OnDetached()
		{
			if (Control != null)
			{
				Control.SetBackgroundColor(Color.Transparent.ToAndroid());
			}
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);
		}
	}
}
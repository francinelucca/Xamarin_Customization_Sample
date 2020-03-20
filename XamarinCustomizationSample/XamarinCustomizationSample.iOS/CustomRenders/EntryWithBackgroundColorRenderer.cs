using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinCustomizationSample.Controls;
using XamarinCustomizationSample.iOS.CustomRenders;

[assembly: ExportRenderer (typeof(EntryWithBackgroundColor), typeof(EntryWithBackgroundColorRenderer))]
namespace XamarinCustomizationSample.iOS.CustomRenders
{
	class EntryWithBackgroundColorRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if(Control != null)
			{
				Control.BackgroundColor = (e.NewElement as EntryWithBackgroundColor).CustomBackgroundColor.ToUIColor();
			}
		}
	}
}
using System;
using System.Collections.Generic;
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
using XamarinCustomizationSample.Controls;
using XamarinCustomizationSample.Droid.CustomRenders;

[assembly: ExportRenderer(typeof(EntryWithBackgroundColor), typeof(EntryWithBackgroundColorRenderer))]
namespace XamarinCustomizationSample.Droid.CustomRenders
{
	public class EntryWithBackgroundColorRenderer : EntryRenderer
	{
		public EntryWithBackgroundColorRenderer(Context context): base(context)
		{

		}
		public EntryWithBackgroundColorRenderer() : base(null)
		{

		}
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if(Control != null)
			{
				if (e.NewElement == null) return;

				var entry = e.NewElement as EntryWithBackgroundColor;
				Control.SetBackgroundColor(entry.CustomBackgroundColor.ToAndroid());
			}
		}
	}
}
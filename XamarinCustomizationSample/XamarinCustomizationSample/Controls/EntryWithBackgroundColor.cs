using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCustomizationSample.Controls
{
	public class EntryWithBackgroundColor : Entry
	{
		public static readonly BindableProperty CustomBackgroundColorProperty =
		BindableProperty.Create(nameof(CustomBackgroundColor), typeof(Color), typeof(EntryWithBackgroundColor), Color.Red);

		public Color CustomBackgroundColor
		{
			get { return (Color)GetValue(CustomBackgroundColorProperty); }
			set { SetValue(CustomBackgroundColorProperty, value); }
		}

	}
}

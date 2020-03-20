using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCustomizationSample.Effects
{
	public class BackgroundColorEffect : RoutingEffect
	{
		public Color BackgroundColor { get; set; } = Color.Red;
		public BackgroundColorEffect() : base("XamarinCustomizationSample.BackgroundColorEffect")
		{

		}
	}
}

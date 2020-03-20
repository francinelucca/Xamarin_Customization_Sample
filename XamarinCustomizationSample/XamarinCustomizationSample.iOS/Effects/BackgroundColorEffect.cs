using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinCustomizationSample.Effects;
using XamarinCustomizationSample.iOS.Effects;

[assembly: ResolutionGroupName("XamarinCustomizationSample")]
[assembly: ExportEffect(typeof(IOSBackgroundColorEffect), "BackgroundColorEffect")]
namespace XamarinCustomizationSample.iOS.Effects
{
	public class IOSBackgroundColorEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			var effect = (BackgroundColorEffect)Element.Effects.FirstOrDefault(e => e is BackgroundColorEffect);
			if(effect != null)
			{
				Control.BackgroundColor = effect.BackgroundColor.ToUIColor();
			}
		}

		protected override void OnDetached()
		{
			var effect = (BackgroundColorEffect)Element.Effects.FirstOrDefault(e => e is BackgroundColorEffect);
			if (effect != null)
			{
				Control.BackgroundColor = Color.Transparent.ToUIColor();
			}
		}
	}
}
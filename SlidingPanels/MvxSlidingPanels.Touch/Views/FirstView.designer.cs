// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MvxSlidingPanels.Touch.Views
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		MonoTouch.UIKit.UILabel DisplayText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DisplayText != null) {
				DisplayText.Dispose ();
				DisplayText = null;
			}
		}
	}
}

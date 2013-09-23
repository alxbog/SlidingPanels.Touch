/// Copyright (C) 2013 Pat Laplante & Franc Caico
///
///	Permission is hereby granted, free of charge, to  any person obtaining a copy 
/// of this software and associated documentation files (the "Software"), to deal 
/// in the Software without  restriction, including without limitation the rights 
/// to use, copy,  modify,  merge, publish,  distribute,  sublicense, and/or sell 
/// copies of the  Software,  and  to  permit  persons  to   whom the Software is 
/// furnished to do so, subject to the following conditions:
///
///		The above  copyright notice  and this permission notice shall be included 
///     in all copies or substantial portions of the Software.
///
///		THE  SOFTWARE  IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
///     OR   IMPLIED,   INCLUDING  BUT   NOT  LIMITED   TO   THE   WARRANTIES  OF 
///     MERCHANTABILITY,  FITNESS  FOR  A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
///     IN NO EVENT SHALL  THE AUTHORS  OR COPYRIGHT  HOLDERS  BE  LIABLE FOR ANY 
///     CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT 
///     OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION  WITH THE SOFTWARE OR 
///     THE USE OR OTHER DEALINGS IN THE SOFTWARE.
/// -----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SlidingPanels.Lib;
using SlidingPanels.Lib.PanelContainers;
using SlidingPanels.Panels;
using SlidingPanels.Lib.Layouts.FollowMe;
using SlidingPanels.Lib.Containers;
using System.Drawing;

namespace SlidingPanels
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			SlidingPanelViewController slidingPanelController = new SlidingPanelViewController();

			window.RootViewController = slidingPanelController;
			window.MakeKeyAndVisible ();

			UINavigationController nav = new UINavigationController (new ExampleContentA (slidingPanelController));

			DisplayConstraints leftConstraints = new DisplayConstraints {
				StartingPosition = new PointF(0, 0),
				Size = new SizeF(200, 0),
				Limit = new PointF(-200, 0),
				ZOrder = 1
			};

			Container leftContainer = new Container {
				Content = new LeftPanelViewController(slidingPanelController, nav),
				Constraints = leftConstraints
			};

			DisplayConstraints middleConstraints = new DisplayConstraints {
				StartingPosition = new PointF(200, 0),
				Size = new SizeF(400, 0),
				Limit = new PointF(0, 0),
				ZOrder = 1
			};

			Container middleContainer = new Container {
				Content = nav,
				Constraints = middleConstraints
			};

			DisplayConstraints rightConstraints = new DisplayConstraints {
				StartingPosition = new PointF(600, 0),
				Size = new SizeF(200, 0),
				Limit = new PointF(0, 0),
				ZOrder = 1
			};

			Container rightContainer = new Container {
				Content = new RightPanelViewController(slidingPanelController, nav),
				Constraints = rightConstraints
			};

			FollowMeLayout layout = new FollowMeLayout ();
			layout.AddPanelContainer (leftContainer);
			layout.AddPanelContainer (rightContainer);
			layout.AddPanelContainer (middleContainer);

			slidingPanelController.AddLayout (layout);

			return true;
		}
	}
}


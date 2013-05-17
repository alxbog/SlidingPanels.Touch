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
using System.Drawing;
using MonoTouch.UIKit;

namespace SlidingPanels.Lib
{
	public interface IPanelView
	{
		/// <summary>
		/// Panel fire this event when they want to replace the main view with something else.
		/// </summary>
		event EventHandler TopViewSwapped;

		/// <summary>
		/// When requested by the sliding panel controller, panel must refresh their content.
		/// </summary>
		void RefreshContent();

		/// <summary>
		/// Gets the desired size of the panel.
		/// </summary>
		/// <returns>The size.</returns>
		SizeF Size { get; }
	}

	public interface ILeftPanelView : IPanelView
	{
	}

	public interface IRightPanelView : IPanelView
	{
	}

	public interface IBottomPanelView : IPanelView
	{
	}
}


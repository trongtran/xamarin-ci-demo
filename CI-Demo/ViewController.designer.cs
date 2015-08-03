// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CIDemo
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton page1Button { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton page2Button { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (page1Button != null) {
				page1Button.Dispose ();
				page1Button = null;
			}
			if (page2Button != null) {
				page2Button.Dispose ();
				page2Button = null;
			}
		}
	}
}

using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace customKeyboard
{
	public partial class MyInputAccessoryView : UIViewController
	{

		public event EventHandler Finished_Clicked;
		public MyInputAccessoryView () : base ("MyInputAccessoryView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void inputFinished_Clicked (MonoTouch.Foundation.NSObject sender)
		{
			if (Finished_Clicked!=null)
			{
				Finished_Clicked(this,EventArgs.Empty );
			}
		}
	}
}


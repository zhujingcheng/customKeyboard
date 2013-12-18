using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace customKeyboard
{
	public partial class PMCustomKeyboard : UIViewController
	{

		public IUITextInputTraits textView{ get; set;}

		public PMCustomKeyboard () : base ("PMCustomKeyboard", null)
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

		public void setTextView(IUITextInputTraits textView) 
		{
			if (textView!=null)
			{

				if (textView is UITextField)
				{
					((UITextField)textView).InputView = this.View;
				}
				else if  (textView is UITextView)
				{
					((UITextView)textView).InputView = this.View;
				}
			}
			this.textView = textView;
		}

		partial void btn_Clicked (MonoTouch.Foundation.NSObject sender)
		{

			if (textView!=null)
			{
				if (textView is UITextField)
				{
					((UITextField)textView).InsertText( "button");
				}
				else if  (textView is UITextView)
				{
					((UITextView)textView).InsertText( "button");
				}
			}
		}
	}
}


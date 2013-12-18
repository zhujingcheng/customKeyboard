using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace customKeyboard
{
	public partial class customKeyboardViewController : UIViewController
	{

		PMCustomKeyboard cuskeyboard = new PMCustomKeyboard ();
		MyInputAccessoryView accessoryView= new MyInputAccessoryView();
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public customKeyboardViewController ()
			: base ("customKeyboardViewController" , null)
		{

			accessoryView.Finished_Clicked+= (sender, e) => {
				//textbox1.ResignFirstResponder();

				//this.View.EndEditing ( true);

				this.scrollView.ScrollRectToVisible (textbox10.Frame, true);

			};
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
			cuskeyboard.setTextView (textbox1);
			cuskeyboard.setTextView (textbox2);
			cuskeyboard.setTextView (textbox3);
			cuskeyboard.setTextView (textbox4);
			cuskeyboard.setTextView (textbox5);
			cuskeyboard.setTextView (textbox6);
			cuskeyboard.setTextView (textbox7);
			cuskeyboard.setTextView (textbox8);
			cuskeyboard.setTextView (textbox9);
			cuskeyboard.setTextView (textbox10);
			cuskeyboard.setTextView (textbox11);
			cuskeyboard.setTextView (textbox12);

			textbox1.InputAccessoryView = accessoryView.View;
			textbox2.InputAccessoryView = accessoryView.View;
			textbox3.InputAccessoryView = accessoryView.View;
			textbox4.InputAccessoryView = accessoryView.View;
			textbox5.InputAccessoryView = accessoryView.View;
			textbox6.InputAccessoryView = accessoryView.View;
			textbox7.InputAccessoryView = accessoryView.View;
			textbox8.InputAccessoryView = accessoryView.View;
			textbox9.InputAccessoryView = accessoryView.View;
			textbox10.InputAccessoryView = accessoryView.View;
			textbox11.InputAccessoryView = accessoryView.View;
			textbox12.InputAccessoryView = accessoryView.View;


			textbox1.Delegate =textbox2.Delegate =textbox3.Delegate =textbox4.Delegate =textbox5.Delegate 
			                    =textbox6.Delegate =textbox7.Delegate =textbox8.Delegate =textbox9.Delegate 
			                    =textbox10.Delegate =textbox11.Delegate =textbox12.Delegate = new txtD (this);

			this.scrollView.ContentSize = new SizeF (320, this.View.Bounds.Height + accessoryView.View.Frame.Height + cuskeyboard.View.Frame.Height);
		}

		class txtD:UITextFieldDelegate
		{
			private customKeyboardViewController controller;
			public txtD(customKeyboardViewController c)
			{
				controller=c;
			}
			 

			public override void EditingStarted (UITextField textField)
			{

				controller.scrollView.ScrollRectToVisible (textField.Frame, true);
			}
		}
	}
}


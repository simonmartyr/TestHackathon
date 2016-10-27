using System;

using UIKit;
using Foundation;
using TestHackathon.BL.WsHandler;

namespace TestHackathon
{
	public partial class FirstViewController : UIViewController
	{
		[Outlet("zipToFind")]
		public UITextField ZipToFind { get; set;}

		[Outlet("findZip")]
		public UIButton FindZip { get; set;}


		NSObject textFieldObserverToken; 

		protected FirstViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


			textFieldObserverToken = UITextField.Notifications.ObserveTextFieldTextDidChange((s, e) =>
			{
				FindZip.Enabled = !string.IsNullOrEmpty(ZipToFind.Text);
			});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void FindZipPress(UIButton sender)
		{
			GetPostCode code = new GetPostCode();
			code.getZip(ZipToFind.Text);


		}

	}
}

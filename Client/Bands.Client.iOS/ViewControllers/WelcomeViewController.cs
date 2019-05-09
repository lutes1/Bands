using System;
using UIKit;

namespace Bands.Views
{
    public class WelcomeViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View = new UIView();
            View.BackgroundColor = UIColor.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Foundation;
using UIKit;

namespace ECoupon.Forms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			ServicePointManager
			.ServerCertificateValidationCallback +=
			(sender, cert, chain, sslPolicyErrors) => true;

            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

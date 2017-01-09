// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AddMobTest.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Google.MobileAds.BannerView adBannerView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (adBannerView != null) {
                adBannerView.Dispose ();
                adBannerView = null;
            }

            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }
        }
    }
}
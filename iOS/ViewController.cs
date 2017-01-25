//
// ViewController.cs
//
// Created by Thomas Dubiel on 06.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using UIKit;
using Google.MobileAds;

namespace AddMobTest.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;
		const string bannerID = "ca-app-pub-7760423869401509/8481587870";

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// ca-app-pub-7760423869401509/8481587870

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				var title = string.Format("{0} clicks!", count++);
				Button.SetTitle(title, UIControlState.Normal);
			};

			adBannerView.AdUnitID = bannerID;
			adBannerView.RootViewController = this;
			adBannerView.AdSize = AdSizeCons.Banner;

			var request = Request.GetDefaultRequest();
			request.TestDevices = new[] { Request.SimulatorId.ToString() };

			adBannerView.LoadRequest(request);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}

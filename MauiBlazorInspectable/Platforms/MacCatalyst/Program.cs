﻿using ObjCRuntime;
using UIKit;

namespace MauiBlazorInspectable;

public class Program
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
        // Add a delay so debugging will work.
        System.Threading.Thread.Sleep(3000);
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
	}
}

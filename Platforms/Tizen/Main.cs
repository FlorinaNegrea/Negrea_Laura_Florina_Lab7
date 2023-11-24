using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Negrea_Laura_Florina_Lab7;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}

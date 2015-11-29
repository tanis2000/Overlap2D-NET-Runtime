
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using Overlap2DNETRuntime;
using Newtonsoft.Json;
using System.IO;


namespace MacTest
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController
	{
		#region Constructors

		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
			var serializer = JsonSerializer.Create ();
			string filePath = NSBundle.MainBundle.PathForResource ("export/scenes/MainScene.dt", null);
			var s = File.OpenText (filePath);
			//var s = File.OpenText ("/Users/tanis/Downloads/overlap2d/examples/OverlapDemo/scenes/MainScene.dt");
			var scene = JsonConvert.DeserializeObject<SceneVO>(s.ReadToEnd());
		}

		#endregion

		//strongly typed window accessor
		public new MainWindow Window {
			get {
				return (MainWindow)base.Window;
			}
		}
	}
}


Overlap2D .NET Runtime
======================

This is a simple port of the original Java runtime of Overlap2D. 

Using this is as simple as referencing the Overlap2D-Net-Runtime project or including the files of the library.
Deserialization can be done with the usual Newtonsoft's JSON serializer like this:

```C#
			var serializer = JsonSerializer.Create ();
			// If you add the Overlap2D exported object to your Resources folder on Mac use the following:
			var s = File.OpenText(NSBundle.MainBundle.PathForResource ("export/scenes/MainScene.dt", null));
			// Otherwise you can directly reference the file path:
			//var s = File.OpenText ("/Users/tanis/Downloads/overlap2d/examples/OverlapDemo/scenes/MainScene.dt");
			// And finally deserialize the JSON to a SceneVO object
			var scene = JsonConvert.DeserializeObject<SceneVO>(s.ReadToEnd());
```
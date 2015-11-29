using System;

namespace Overlap2DNETRuntime
{
	public class FrameRange
	{
		public String name;
		public int startFrame;
		public int endFrame;

		public FrameRange() {

		}

		public FrameRange(String name, int startFrame, int endFrame) {
			this.name = name;
			this.startFrame = startFrame;
			this.endFrame = endFrame;
		}
	}
}


using System;

namespace Overlap2DNETRuntime
{
	public class ResolutionEntryVO
	{
		public String name = "";

		public int width;
		public int height;
		public int baseResolution;

		public override String ToString() {
			if (width == 0 && height == 0) {
				return name;
			}
			return width + "x" + height + " (" + name + ")";
		}

		public override bool Equals(Object obj) {
			if (obj == null) {
				return false;
			}

			ResolutionEntryVO other = obj as ResolutionEntryVO;
			if ((System.Object)other == null) {
				return false;
			}

			return other.name.Equals(name);
		}

		public float getMultiplier(ResolutionEntryVO originalResolution) {
			float mul;
			if(baseResolution == 0) {
				mul = (float)originalResolution.width/width;
			} else {
				mul = (float)originalResolution.height/height;
			}
			return mul;
		}	}
}


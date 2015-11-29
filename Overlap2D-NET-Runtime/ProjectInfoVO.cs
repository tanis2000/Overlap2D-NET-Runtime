using System;
using System.Collections;
using System.Collections.Generic;

namespace Overlap2DNETRuntime
{
	public class ProjectInfoVO
	{
		public int pixelToWorld = 1;

		public ResolutionEntryVO originalResolution = new ResolutionEntryVO();

		public List<ResolutionEntryVO> resolutions = new List<ResolutionEntryVO>();
		public List<SceneVO> scenes = new List<SceneVO>();

		public Dictionary<String, CompositeItemVO> libraryItems = new Dictionary<String, CompositeItemVO>();

		public String constructJsonString() {
			String str = "";
			/*Json json = new Json();
			json.setOutputType(OutputType.json);
			str = json.toJson(this);
			json.prettyPrint(str);*/
			return str;
		}

		public ResolutionEntryVO getResolution(String name) {
			foreach (ResolutionEntryVO resolution in resolutions) {
				if (resolution.name.ToLower() == name.ToLower()) {
					return resolution;
				}
			}
			return null;
		}

	}
}


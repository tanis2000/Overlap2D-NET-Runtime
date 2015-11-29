using System;
using System.Collections;
using System.Collections.Generic;

namespace Overlap2DNETRuntime
{
	public class SceneVO
	{
		public String sceneName = "";

		public CompositeVO composite;

		public bool lightSystemEnabled = false;

		public float[] ambientColor = {1f, 1f, 1f, 1f};

		public PhysicsPropertiesVO physicsPropertiesVO = new PhysicsPropertiesVO();

		public List<float> verticalGuides = new List<float>();
		public List<float> horizontalGuides = new List<float>();

		public SceneVO() {

		}

		public SceneVO(SceneVO vo) {
			sceneName = vo.sceneName;
			composite = new CompositeVO(vo.composite);
			ambientColor = vo.ambientColor;
			physicsPropertiesVO = new PhysicsPropertiesVO(vo.physicsPropertiesVO);
			lightSystemEnabled = vo.lightSystemEnabled;
		}

		public String constructJsonString() {
			String str = "";
			/*Json json = new Json();
			json.setOutputType(OutputType.json);
			str = json.toJson(this);*/
			return str;
		}	}
}


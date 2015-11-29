using System;

namespace Overlap2DNETRuntime
{
	public class LayerItemVO
	{
		public String layerName = "";
		public bool isLocked = false;
		public bool isVisible = false;

		public LayerItemVO() {

		}

		public LayerItemVO(String name) {
			layerName = name;
			isVisible = true;
		}

		public LayerItemVO(LayerItemVO vo) {
			layerName = vo.layerName;
			isLocked = vo.isLocked;
			isVisible = vo.isVisible;
		}

		public static LayerItemVO createDefault() {
			LayerItemVO layerItemVO = new LayerItemVO();
			layerItemVO.layerName = "Default";
			layerItemVO.isVisible = true;
			return layerItemVO;
		}	}
}


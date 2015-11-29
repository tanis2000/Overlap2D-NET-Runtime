using System;

namespace Overlap2DNETRuntime
{
	public class SimpleImageVO : MainItemVO
	{
		public String imageName = "";
		public bool isRepeat = false;
		public bool isPolygon = false;

		public SimpleImageVO() : base() {
		}

		public SimpleImageVO(SimpleImageVO vo) : base(vo) {
			imageName = vo.imageName;
		}

		/*
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);

			TextureRegionComponent textureRegionComponent = entity.getComponent(TextureRegionComponent.class);
			imageName = textureRegionComponent.regionName;
			isRepeat = textureRegionComponent.isRepeat;
			isPolygon = textureRegionComponent.isPolygon;
		}*/

	}
}


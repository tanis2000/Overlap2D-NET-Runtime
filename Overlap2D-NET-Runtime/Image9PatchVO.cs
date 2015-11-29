using System;

namespace Overlap2DNETRuntime
{
	public class Image9patchVO : MainItemVO
	{
		public String imageName = "";
		public float width = 0;
		public float height = 0;

		public Image9patchVO() : base() {
		}

		public Image9patchVO(Image9patchVO vo) : base(vo) {
			imageName = vo.imageName;
			width = vo.width;
			height = vo.height;
		}

		/*
		@Override
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);

			NinePatchComponent ninePatchComponent = entity.getComponent(NinePatchComponent.class);
			DimensionsComponent dimensionsComponent = entity.getComponent(DimensionsComponent.class);
			imageName = ninePatchComponent.textureRegionName;

			width = dimensionsComponent.width;
			height = dimensionsComponent.height;
		}*/
	}
}


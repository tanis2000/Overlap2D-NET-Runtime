using System;

namespace Overlap2DNETRuntime
{
	public class SpineVO : MainItemVO
	{
		public String animationName = "";
		public String currentAnimationName = "";

		public SpineVO() : base() {

		}

		public SpineVO(SpineVO vo) : base(vo) {
			animationName = vo.animationName;
			currentAnimationName = vo.currentAnimationName;
		}

		/*
		@Override
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);

			SpineDataComponent spineDataComponent = entity.getComponent(SpineDataComponent.class);
			animationName = spineDataComponent.animationName;
			currentAnimationName = spineDataComponent.currentAnimationName;
		}*/
	}
}


using System;

namespace Overlap2DNETRuntime
{
	public class SpriterVO : MainItemVO
	{
		public int 	entity;
		public int 	animation;
		public String animationName = "";

		//wtf is this?
		public float scale	=	1f;

		public SpriterVO() : base() {

		}

		public SpriterVO(SpriterVO vo) : base(vo) {
			entity 			= vo.entity;
			animation		= vo.animation;
			animationName 	= vo.animationName;
			scale 			= vo.scale;
		}

		/*
		@Override
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);

			SpriterComponent spriterComponent = entity.getComponent(SpriterComponent.class);
			animationName = spriterComponent.animationName;
			animation = spriterComponent.animation;
		}*/
	}
}


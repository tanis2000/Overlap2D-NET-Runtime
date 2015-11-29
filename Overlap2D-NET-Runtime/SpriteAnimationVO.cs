using System;
using System.Collections;
using System.Collections.Generic;

namespace Overlap2DNETRuntime
{
	public class SpriteAnimationVO : MainItemVO
	{
		public String animationName = "";
		public int fps = 24;
		public String currentAnimation;
		public List<FrameRange> frameRangeMap = new List<FrameRange>();
		public int playMode = 0;

		public SpriteAnimationVO() : base() {

		}

		public SpriteAnimationVO(SpriteAnimationVO vo) : base(vo) {
			animationName = vo.animationName;
			fps = vo.fps;
			frameRangeMap = vo.frameRangeMap;
		}

		/*
		@Override
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);

			SpriteAnimationComponent spriteAnimationComponent = entity.getComponent(SpriteAnimationComponent.class);
			animationName = spriteAnimationComponent.animationName;
			fps = spriteAnimationComponent.fps;
			frameRangeMap = new ArrayList<FrameRange>();
			for(FrameRange fr: spriteAnimationComponent.frameRangeMap.values()) {
				frameRangeMap.add(fr);
			}
			currentAnimation = spriteAnimationComponent.currentAnimation;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.NORMAL) playMode = 0;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.REVERSED) playMode = 1;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.LOOP) playMode = 2;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.LOOP_REVERSED) playMode = 3;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.LOOP_PINGPONG) playMode = 4;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.LOOP_RANDOM) playMode = 5;
			if(spriteAnimationComponent.playMode == Animation.PlayMode.NORMAL) playMode = 6;
		}*/
	}
}


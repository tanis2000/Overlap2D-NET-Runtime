﻿/*
The MIT License (MIT)

Copyright (c) 2015 Valerio Santinelli

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
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


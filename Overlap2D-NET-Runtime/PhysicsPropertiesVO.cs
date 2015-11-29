using System;

namespace Overlap2DNETRuntime
{
	public class PhysicsPropertiesVO
	{
		public float gravityX;
		public float gravityY;
		public float sleepVelocity;
		public bool enabled;

		public PhysicsPropertiesVO() {
			gravityX = 0;
			gravityY = 0;
			sleepVelocity = 0;
			enabled = false;
		}

		public PhysicsPropertiesVO(PhysicsPropertiesVO physicsPropertiesVO) {
			this.gravityX = physicsPropertiesVO.gravityX;
			this.gravityY = physicsPropertiesVO.gravityY;
			this.sleepVelocity = physicsPropertiesVO.sleepVelocity;
			this.enabled = physicsPropertiesVO.enabled;
		}	}
}


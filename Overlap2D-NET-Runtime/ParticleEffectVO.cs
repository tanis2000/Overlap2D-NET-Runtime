using System;

namespace Overlap2DNETRuntime
{
	public class ParticleEffectVO : MainItemVO
	{
		public String particleName = "";
		public float particleWidth = 100;
		public float particleHeight = 100;
		//TODO add other ParticleEffect properties 

		public ParticleEffectVO() : base() {
		}

		public ParticleEffectVO(ParticleEffectVO vo) : base(vo) {
			particleName = vo.particleName;
		}

		/*
		@Override
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);

			ParticleComponent particleComponent = entity.getComponent(ParticleComponent.class);
			particleName = particleComponent.particleName;
		}*/
	}
}


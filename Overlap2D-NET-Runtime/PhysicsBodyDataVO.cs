using System;

namespace Overlap2DNETRuntime
{
	public class PhysicsBodyDataVO
	{
		public int bodyType = 0;

		public float mass;
		public Vector2 centerOfMass;
		public float rotationalInertia;
		public float damping;
		public float gravityScale;
		public bool allowSleep;
		public bool awake;
		public bool bullet;
		public bool sensor;

		public float density;
		public float friction;
		public float restitution;

		public PhysicsBodyDataVO(){
			centerOfMass = new Vector2();
		}

		public PhysicsBodyDataVO(PhysicsBodyDataVO vo){
			bodyType = vo.bodyType;
			mass = vo.mass;
			centerOfMass = vo.centerOfMass;
			rotationalInertia = vo.rotationalInertia;
			damping = vo.damping;
			gravityScale = vo.gravityScale;
			allowSleep = vo.allowSleep;
			sensor = vo.sensor;
			awake = vo.awake;
			bullet = vo.bullet;
			density = vo.density;
			friction = vo.friction;
			restitution = vo.restitution;
		}

		/*
		public void loadFromComponent(PhysicsBodyComponent physicsComponent) {
			bodyType = physicsComponent.bodyType;
			mass = physicsComponent.mass;
			centerOfMass = physicsComponent.centerOfMass.cpy();
			rotationalInertia = physicsComponent.rotationalInertia;
			damping = physicsComponent.damping;
			gravityScale = physicsComponent.gravityScale;
			allowSleep = physicsComponent.allowSleep;
			sensor = physicsComponent.sensor;
			awake = physicsComponent.awake;
			bullet = physicsComponent.bullet;
			density = physicsComponent.density;
			friction = physicsComponent.friction;
			restitution = physicsComponent.restitution;
		}*/
	}
}


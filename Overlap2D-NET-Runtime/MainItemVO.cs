using System;

namespace Overlap2DNETRuntime
{
	public class MainItemVO
	{
		public int uniqueId = -1;
		public String itemIdentifier = "";
		public String itemName = "";
		public String[] tags = null;
		public String customVars = "";
		public float x; 
		public float y;
		public float scaleX	=	1f; 
		public float scaleY	=	1f;
		public float originX	= 0;
		public float originY	= 0;
		public float rotation;
		public int zIndex = 0;
		public String layerName = "";
		public float[] tint = {1, 1, 1, 1};

		public String shaderName = "";

		public ShapeVO shape = null;
		public PhysicsBodyDataVO physics = null;

		public MainItemVO() {

		}

		public MainItemVO(MainItemVO vo) {
			uniqueId = vo.uniqueId;
			itemIdentifier = vo.itemIdentifier;
			itemName = vo.itemName;
			if (tags != null)
				tags = (string[])vo.tags.Clone();
			customVars = vo.customVars;
			x = vo.x; 
			y = vo.y;
			rotation = vo.rotation;
			zIndex = vo.zIndex;
			layerName = vo.layerName;
			if(vo.tint != null) tint = (float[])vo.tint.Clone();
			scaleX 		= vo.scaleX;
			scaleY 		= vo.scaleY;
			originX 	= vo.originX;
			originY 	= vo.originY;

			if(vo.shape != null) {
				shape = vo.shape.clone();
			}

			if(vo.physics != null){
				physics = new PhysicsBodyDataVO(vo.physics);
			}
		}

		/*
		public void loadFromEntity(Entity entity) {
			MainItemComponent mainItemComponent = entity.getComponent(MainItemComponent.class);
			TransformComponent transformComponent = entity.getComponent(TransformComponent.class);
			TintComponent tintComponent = entity.getComponent(TintComponent.class);
			ZIndexComponent zindexComponent = entity.getComponent(ZIndexComponent.class);

			uniqueId = mainItemComponent.uniqueId;
			itemIdentifier = mainItemComponent.itemIdentifier;
			itemName = mainItemComponent.libraryLink;
			tags = new String[mainItemComponent.tags.size()];
			tags = mainItemComponent.tags.toArray(tags);
			customVars = mainItemComponent.customVars;

			x = transformComponent.x;
			y = transformComponent.y;
			scaleX = transformComponent.scaleX;
			scaleY = transformComponent.scaleY;
			originX = transformComponent.originX;
			originY = transformComponent.originY;
			rotation = transformComponent.rotation;

			layerName = zindexComponent.layerName;

			tint = new float[4];
			tint[0] = tintComponent.color.r;
			tint[1] = tintComponent.color.g;
			tint[2] = tintComponent.color.b;
			tint[3] = tintComponent.color.a;

			zIndex = zindexComponent.getZIndex();

		   //Secondary components
			PolygonComponent polygonComponent = entity.getComponent(PolygonComponent.class);
			if(polygonComponent != null && polygonComponent.vertices != null) {
				shape = new ShapeVO();
				shape.polygons = polygonComponent.vertices;
			}
			PhysicsBodyComponent physicsComponent = entity.getComponent(PhysicsBodyComponent.class);
			if(physicsComponent != null) {
				physics = new PhysicsBodyDataVO();
				physics.loadFromComponent(physicsComponent);
			}

			ShaderComponent shaderComponent = entity.getComponent(ShaderComponent.class);
			if(shaderComponent != null && shaderComponent.shaderName != null) {
				shaderName = shaderComponent.shaderName;
			}
		} */
	}
}


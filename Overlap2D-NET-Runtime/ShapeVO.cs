using System;

namespace Overlap2DNETRuntime
{
	public class ShapeVO
	{
		public Vector2[][] polygons;
		public Circle[] circles;

		public ShapeVO clone() {
			ShapeVO newVo = new ShapeVO();
			Vector2 [][] target = new Vector2[polygons.Length][];

			for (int i = 0; i < polygons.Length; i++) {
				target[i] = new Vector2[polygons[i].Length];
				for(int j=0;j<polygons[i].Length;j++){
					target[i][j] = polygons[i][j];
				}
			}
			newVo.polygons = target;

			return newVo;
		}

		public static ShapeVO createRect(float width, float height) {
			ShapeVO vo = new ShapeVO();
			vo.polygons = new Vector2[1][];

			vo.polygons[0] = new Vector2[4];
			vo.polygons[0][0] = new Vector2(0, 0);
			vo.polygons[0][1] = new Vector2(0, height);
			vo.polygons[0][2] = new Vector2(width, height);
			vo.polygons[0][3] = new Vector2(width, 0);

			return vo;
		}
	}
}


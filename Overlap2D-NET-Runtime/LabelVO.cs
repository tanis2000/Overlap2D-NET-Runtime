using System;

namespace Overlap2DNETRuntime
{
	public class LabelVO : MainItemVO
	{
		public String 	text 	= "Label";
		public String	style	=  "";
		public int		size;
		public int		align;

		public float width = 0;
		public float height = 0;

		public bool multiline = false;

		public LabelVO() : base() {
		}

		public LabelVO(LabelVO vo) : base(vo) {
			text 	= vo.text;
			style 	= vo.style;
			size 	= vo.size;
			align 	= vo.align;
			width 	= vo.width;
			height 	= vo.height;
			multiline 	= vo.multiline;
		}

		/*
		@Override
		public void loadFromEntity(Entity entity) {
			super.loadFromEntity(entity);
			LabelComponent labelComponent = entity.getComponent(LabelComponent.class);
			DimensionsComponent dimensionsComponent = entity.getComponent(DimensionsComponent.class);
			text = labelComponent.getText().toString();
			style = labelComponent.fontName;
			size = labelComponent.fontSize;
			align = labelComponent.labelAlign;
			multiline = labelComponent.wrap;

			width = dimensionsComponent.width;
			height = dimensionsComponent.height;
		}*/
	}
		
}


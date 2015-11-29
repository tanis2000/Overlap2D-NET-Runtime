using System;

namespace Overlap2DNETRuntime
{
	public class TextBoxVO : MainItemVO
	{
		public String defaultText = "";
		public float width = 0;
		public float height = 0;
		public String	style	=  "";

		public TextBoxVO() : base() {
		}

		public TextBoxVO(TextBoxVO vo) : base(vo) {
			defaultText = vo.defaultText;
			width 		= vo.width;
			height 		= vo.height;
			style 		= vo.style;
		}	
	}
}


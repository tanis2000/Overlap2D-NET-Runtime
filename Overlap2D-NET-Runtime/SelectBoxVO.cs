using System;
using System.Collections;
using System.Collections.Generic;

namespace Overlap2DNETRuntime
{
	public class SelectBoxVO : MainItemVO
	{
		public List<String>	list	=	new List<String>();
		public String	style	=  "";
		public float width = 0;
		public float height = 0;

		public SelectBoxVO() : base() {
		}

		public SelectBoxVO(SelectBoxVO vo) : base(vo) {
			width 		= vo.width;
			height 		= vo.height;
			style = vo.style;
		}
	}
}


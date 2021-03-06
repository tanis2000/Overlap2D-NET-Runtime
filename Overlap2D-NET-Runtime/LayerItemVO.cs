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

namespace Overlap2DNETRuntime
{
	public class LayerItemVO
	{
		public String layerName = "";
		public bool isLocked = false;
		public bool isVisible = false;

		public LayerItemVO() {

		}

		public LayerItemVO(String name) {
			layerName = name;
			isVisible = true;
		}

		public LayerItemVO(LayerItemVO vo) {
			layerName = vo.layerName;
			isLocked = vo.isLocked;
			isVisible = vo.isVisible;
		}

		public static LayerItemVO createDefault() {
			LayerItemVO layerItemVO = new LayerItemVO();
			layerItemVO.layerName = "Default";
			layerItemVO.isVisible = true;
			return layerItemVO;
		}	}
}


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
	public class ResolutionEntryVO
	{
		public String name = "";

		public int width;
		public int height;
		public int baseResolution;

		public override String ToString() {
			if (width == 0 && height == 0) {
				return name;
			}
			return width + "x" + height + " (" + name + ")";
		}

		public override bool Equals(Object obj) {
			if (obj == null) {
				return false;
			}

			ResolutionEntryVO other = obj as ResolutionEntryVO;
			if ((System.Object)other == null) {
				return false;
			}

			return other.name.Equals(name);
		}

		public float getMultiplier(ResolutionEntryVO originalResolution) {
			float mul;
			if(baseResolution == 0) {
				mul = (float)originalResolution.width/width;
			} else {
				mul = (float)originalResolution.height/height;
			}
			return mul;
		}	}
}


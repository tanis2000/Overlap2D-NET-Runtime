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
using System.Collections;
using System.Collections.Generic;

namespace Overlap2DNETRuntime
{
	public class ProjectInfoVO
	{
		public int pixelToWorld = 1;

		public ResolutionEntryVO originalResolution = new ResolutionEntryVO();

		public List<ResolutionEntryVO> resolutions = new List<ResolutionEntryVO>();
		public List<SceneVO> scenes = new List<SceneVO>();

		public Dictionary<String, CompositeItemVO> libraryItems = new Dictionary<String, CompositeItemVO>();

		public String constructJsonString() {
			String str = "";
			/*Json json = new Json();
			json.setOutputType(OutputType.json);
			str = json.toJson(this);
			json.prettyPrint(str);*/
			return str;
		}

		public ResolutionEntryVO getResolution(String name) {
			foreach (ResolutionEntryVO resolution in resolutions) {
				if (resolution.name.ToLower() == name.ToLower()) {
					return resolution;
				}
			}
			return null;
		}

	}
}


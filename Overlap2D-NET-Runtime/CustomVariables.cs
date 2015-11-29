using System;
using System.Collections;
using System.Collections.Generic;

namespace Overlap2DNETRuntime
{
	public class CustomVariables
	{
		private Dictionary<String, String> variables = new Dictionary<String, String>();

		public CustomVariables() {

		}

		public void loadFromString(String varString) {
			variables.Clear();
			String[] vars = varString.Split(';');
			for(int i = 0; i < vars.Length; i++) {
				String[] tmp = vars[i].Split(':');
				if(tmp.Length > 1) {
					setVariable(tmp[0], tmp[1]);
				}
			}
		}

		public String saveAsString() {
			String result = "";
			foreach (var entry in variables) {
				String key = entry.Key;
				String value = entry.Value;
				result += key + ":" + value + ";";
			}
			if(result.Length > 0) {
				result = result.Substring(0, result.Length-1);
			}

			return result;
		}

		public void setVariable(String key, String value) {
			variables.Add(key, value);
		}

		public void removeVariable(String key) {
			variables.Remove(key);
		}

		public String getStringVariable(String key) {
			return variables[key];
		}

		public int getIntegerVariable(String key) {
			int result = 0;
			try {
				result = int.Parse(variables[key]);
			} catch(Exception e) {}

			return result;
		}

		public float getFloatVariable(String key) {
			float result = 0;
			try {
				result = float.Parse(variables[key]);
			} catch(Exception e) {}

			return result;
		}

		public Dictionary<String, String> getHashMap() {
			return variables;
		}

		public int getCount() {
			return variables.Count;
		}
	}
}


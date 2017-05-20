using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Log
{
	public class SelectListLog : BaseLog
	{

		public override string ToHtml()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<div>");
			//<select>
			//  <option>Пункт 1</option>
			//  <option>Пункт 2</option>
			//</select>

			sb.AppendLine("<select>");
			for (var i = 0; i < people.Count; i++)
			{
				sb.AppendLine("<option>");
				sb.Append(GetName(i));
				sb.AppendLine("</option>");
			}
			sb.AppendLine("</select>");
			sb.AppendLine("</div>");
			return sb.ToString();
		}
	}
}

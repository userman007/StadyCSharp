using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Log
{
	public class BaseLog
	{
		protected List<Person> people;
		
		public string GetName(int index)
		{
			return string.Format("{0} {1}", people[index].FirstName, people[index].LastName);
		}

		public void AddPerson(Person person)
		{
			if (person == null) return;
			if (people == null) people = new List<Person>();
			people.Add(person);
		}

		public virtual string ToHtml()
		{
			StringBuilder sb = new StringBuilder();
			for (var i = 0; i < people.Count; i++)
				sb.Append(GetName(i));
			return sb.ToString();
		}
	}
}

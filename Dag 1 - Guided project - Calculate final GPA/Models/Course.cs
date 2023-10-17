using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Guided_project___Calculate_final_GPA.Models
{
	public class Course
	{
		public Course(string name, int grade, int credit)
		{
			Name = name;
			Grade = grade;
			Credit = credit;
		}
		public string Name { get; set; }
		public int Grade { get; set; }
		public int Credit { get; set; }
	}
}

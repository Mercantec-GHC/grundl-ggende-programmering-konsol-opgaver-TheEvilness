using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Guided_project___Calculate_final_GPA.Models
{
	public class Student
	{
		public Student(string name, Course[] courses)
		{
			Name = name;
			Courses = courses;
		}
		public string Name { get; set; }
		public Course[] Courses { get; set; }
	}
}

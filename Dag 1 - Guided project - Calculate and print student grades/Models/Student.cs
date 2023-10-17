using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Guided_project___Calculate_and_print_student_grades.Models
{
	public class Student
	{
		public Student(string name, int[] scores)
		{
			Name = name;
			Scores = scores;
		}
		public string Name { get; set; }
		public int[] Scores { get; set; }
	}
}

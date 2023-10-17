// initialize variables - graded assignments 
using Dag_1___Guided_project___Calculate_and_print_student_grades.Models;

List<Student> students = new List<Student>();
students.Add(new Student("Sophia", new int[] { 93, 87, 98, 95, 100 }));

students.Add(new Student("Nicolas", new int[] { 80, 83, 82, 88, 85 }));

students.Add(new Student("Zahirah", new int[] { 84, 96, 73, 85, 79 }));

students.Add(new Student("Jeong", new int[] { 90, 92, 98, 100, 97 }));

Console.WriteLine($"Student\t\tGrade");
foreach (Student student in students)
{
	int total = 0;
	char grade = 'X';
	foreach (int score in student.Scores)
	{	
		total += score;
	}
	decimal average = (decimal)total / student.Scores.Count();
	if (average > 80m)
	{
		grade = 'B';
	}
	if (average > 90m)
	{
		grade = 'A';
	}
	Console.WriteLine($"{student.Name}\t\t{average}  {grade}");
}
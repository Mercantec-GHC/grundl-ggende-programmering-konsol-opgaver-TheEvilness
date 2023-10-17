using Dag_1___Guided_project___Calculate_final_GPA.Models;

Course[] courses = new Course[]
{
	new Course("English 101", 4, 3),
	new Course("Algebra 101", 3, 3),
	new Course("Biology 101", 3, 4),
	new Course("Computer Science I", 3, 4),
	new Course("Psychlogy 101", 4, 3)
};

Student student = new Student("Sophia Johnson", courses);

decimal totalGrade = 0m;
int totalCreditHours = 0;
Console.WriteLine($"Student: {student.Name}");
Console.WriteLine("");
Console.WriteLine($"Course\tGrade\t\tCredit Hours");
foreach (Course course in student.Courses)
{
	//We do this just to make sure Computer Science I's line does not explode..
	//Remove the if statement and see what I mean.
	string tabsBetweenCourseAndGrade = "\t\t";
	if (course.Name == "Computer Science I")
	{
		tabsBetweenCourseAndGrade = "\t";
	}
	//End ugly code

	Console.WriteLine($"{course.Name}{tabsBetweenCourseAndGrade}{course.Grade}\t{course.Credit}");
	totalGrade += (course.Grade * course.Credit);
	totalCreditHours += course.Credit;
}
Console.WriteLine("");
Console.WriteLine($"Final GPA:\t{(totalGrade / totalCreditHours).ToString("#.##")}");
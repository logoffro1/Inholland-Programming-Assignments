using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }
        void Start()
        {
            List<Course> courses = ReadGradeList(3);
            DisplayGradeList(courses);
        }
        private List<Course> ReadGradeList(int nrOfCourses)
        {
            List<Course> courses = new List<Course>();
            for (int i = 0; i < nrOfCourses; i++)
                courses.Add(ReadCourse("Enter a course."));

            return courses;
        }
        private void DisplayGradeList(List<Course> gradeList)
        {
            int retakes = 0;
            bool cumLaude = false;
            for (int i = 0; i < gradeList.Count; i++)
            {
                DisplayCourse(gradeList[i]);
                if (!gradeList[i].Passed())
                    retakes++;

                if (gradeList[i].CumLaude())
                    cumLaude = true;
            }
            if(retakes > 0)
                Console.WriteLine($"Too bad, you did not graduate, you got {retakes} retakes.");
            else
            {
                if(cumLaude)
                    Console.WriteLine("Congratulations, you graduated Cum Laude!");
                else
                    Console.WriteLine("Congratulations, you graduated!");
            }
        }
        private PracticalGrade ReadPracticalGrade(string question)
        {
            Console.WriteLine("0. None | 1. Absent | 2. Insufficient | 3. Sufficient | 4. Good");
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            return (PracticalGrade)int.Parse(Console.ReadLine());
        }
        private void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.Write(practical);

        }
        private Course ReadCourse(string question)
        {
            Console.WriteLine(question);
            Course course = new Course();
            course.Name = ReadString("Name of the course: ");
            Console.ResetColor();
            course.Grade = ReadInt($"Grade for {course.Name}: ");
            Console.ResetColor();
            course.practicalGrade = ReadPracticalGrade($"Practical grade for {course.Name}: ");
            Console.ResetColor();
            Console.WriteLine();
            return course;
        }
        void DisplayCourse(Course course)
        {
            Console.Write($"{course.Name,-14} : {course.Grade}     ");
            DisplayPracticalGrade(course.practicalGrade);
            Console.WriteLine();
        }
        private int ReadInt(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            return int.Parse(Console.ReadLine());
        }
        private string ReadString(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadLine();
        }

    }
}

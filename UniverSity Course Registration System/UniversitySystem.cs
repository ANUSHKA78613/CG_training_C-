using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }
        public List<Student> ActiveStudents{get; private set;}
        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
            ActiveStudents = new List<Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            Course c = new Course(code,name,credits,maxCapacity,prerequisites);
            if (AvailableCourses.ContainsKey(code))
            {
             throw new ArgumentException("Course exist");   
            }
                AvailableCourses.Add(code,c);
            }
        

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException("id already exixt");
            }
            Student s = new Student(id,name,major,maxCredits,completedCourses);
            Students.Add(id,s);
            ActiveStudents.Add(s);
        }

      public bool RegisterStudentForCourse(string studentId, string courseCode)
{
    if (!Students.ContainsKey(studentId) || !AvailableCourses.ContainsKey(courseCode))
    {
        Console.WriteLine("Student or Course not found.");
        return false;
    }

    Student s = Students[studentId];
    Course c = AvailableCourses[courseCode];

    if (s.AddCourse(c))
    {
        Console.WriteLine(
            $"Registration successful! Total credits: {s.GetTotalCredits()}/{s.MaxCredits}."
        );
        return true;
    }

    Console.WriteLine("Registration failed (check prerequisites, credits, or capacity).");
    return false;
}


        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (!Students.ContainsKey(studentId))
            {
                return false;
            }
            return Students[studentId].DropCourse(courseCode);
        }
      public void DisplayAllCourses()
{
    if (AvailableCourses.Count == 0)
    {
        Console.WriteLine("No courses available.");
        return;
    }

    Console.WriteLine("Available Courses:");
    Console.WriteLine("Code\tName\t\t\tCredits\tEnrollment");

    foreach (Course c in AvailableCourses.Values)
    {
        Console.WriteLine(  $"{c.CourseCode}\t{c.CourseName}\t{c.Credits}\t{c.GetEnrollmentInfo()}" );
    }
}


        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            if (!Students.ContainsKey(studentId))
            {
                throw new ArgumentException("student not found");
            }
            Students[studentId].DisplaySchedule();
        }

       public void DisplaySystemSummary()
{
    int totalEnrollment = 0;

    foreach (Course c in AvailableCourses.Values)
    {
        totalEnrollment += int.Parse(c.GetEnrollmentInfo().Split('/')[0]);
    }

    double avgEnrollment = AvailableCourses.Count == 0
        ? 0
        : (double)totalEnrollment / AvailableCourses.Count;

    Console.WriteLine("System Summary:");
    Console.WriteLine($"- Total Students: {Students.Count}");
    Console.WriteLine($"- Total Courses: {AvailableCourses.Count}");
    Console.WriteLine($"- Average Enrollment: {avgEnrollment:F1}");
}

    }
}

class College
{
    public College()
    {
    }

    public void RegisterStudent(Student student)
    {
    }

    public void AssignStudentToCourse(Student student, Course course)
    {
    }

    public void AssignTeacherToCourse(Teacher teacher, Course course)
    {
    }

    public List<Student> GetRegisteredStudents()
    {
        return new List<Student>();
    }

    public List<Teacher> GetRegisteredTeachers()
    {
        return new List<Teacher>();
    }

    public List<Course> GetAvailableCourses()
    {
        return new List<Course>();
    }
}

class Student
{
    public Student(string name, int age, string major)
    {
    }

    public void DisplayInfo()
    {
    }
}

class Course
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Course(string name, string description)
    {
        Name = name;
        Description = description;
    }
}

class Teacher
{
    public Teacher(string name, int age, string department)
    {
    }

    public void DisplayInfo()
    {
    }
}

public class Program
{
    public static void Main()
    {
        College college = new College();

        Student newStudent = new Student("John Doe", 28, "Computer Science");
        college.RegisterStudent(newStudent);

        Course programmingCourse = new Course("Programming 101", "Introduction to Programming");
        college.AssignStudentToCourse(newStudent, programmingCourse);

        Teacher newTeacher = new Teacher("Prof. Smith", 35, "Computer Science");
        college.AssignTeacherToCourse(newTeacher, programmingCourse);

        Console.WriteLine("Registered Students:");
        foreach (var student in college.GetRegisteredStudents())
        {
            student.DisplayInfo();
        }

        Console.WriteLine("\nRegistered Teachers:");
        foreach (var teacher in college.GetRegisteredTeachers())
        {
            teacher.DisplayInfo();
        }

        Console.WriteLine("\nAvailable Courses:");
        foreach (var course in college.GetAvailableCourses())
        {
            Console.WriteLine($"Course: {course.Name}, Description: {course.Description}");
        }
    }
}
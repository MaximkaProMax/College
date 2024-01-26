using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; set; }
    public string Description { get; set; }

    public List<Student> students = new List<Student>();
    public List<Teacher> teachers = new List<Teacher>();
    public List<Course> courses = new List<Course>();

    public void RegisterStudent(Student student)
    {
        students.Add(student);
    }

    public void AssignStudentToCourse(Student student, Course course)
    {
        course.students.Add(student);
    }

    public void AssignTeacherToCourse(Teacher teacher, Course course)
    {
        course.teachers.Add(teacher);
    }
}
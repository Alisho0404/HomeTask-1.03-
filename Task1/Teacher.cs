using System;

namespace Task1;

public class Teacher : Person
{
    private int _numCourses;
    private string[] _courses = new string[5];
    public Teacher(string name, string address) : base(name, address)
    {

    }
    public bool AddCourse(string course)
    {
        foreach (var item in _courses)
        { 
            if (item != course)
            { 
                if (_numCourses < 5)
            {
                _courses[_numCourses] = course;
                _numCourses++;
            } 
                return true;
            }
            
            else
            {
                System.Console.WriteLine("One teacher can teach 5 subject"); 
                return false;
            }


        }

        return false;
    }
    public bool RemoveCourse(string course)
    {
        for (int i = 0; i < _numCourses; i++)
        {
            if (_courses[i] == course)
            {
                _courses[i].Remove(i);
                _numCourses--;
                return true;
            }
        }
        return false;
    }
    public override string ToString()
    {
        return $"Teacher: {base.ToString()}";
    }
}

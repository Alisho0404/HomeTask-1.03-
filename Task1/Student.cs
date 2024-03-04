namespace Task1;

public class Student:Person
{
    private int _numCourses=0; 
    private string [] _courses= new string[30]; 
    private int[] _grades= new int[30];
    
    public Student(string name, string address):base(name,address)
    {
        
    } 

    public void AddCourse(string course, int grade)
    {
        if (_numCourses<30)
        { 
            _courses[_numCourses] = course;
            _grades[_numCourses] = grade;
            _numCourses++;
        } 
        else {
            System.Console.WriteLine("Student must have 30 courses");
        }    
    } 

    public void PrintGrades()
    {
         for (int i = 0; i < _numCourses; i++)
         {
            System.Console.Write(_grades[i]+" ");
         }
    } 
    
    public double GetAverageGrade()
    { 
        double sum=0;
        for (int i = 0; i < _numCourses; i++)
        {
           sum+=_grades[i];
        }

        return sum/_numCourses;
    }
    
    public override string ToString()
    {
        return $"Student: {base.ToString()}";
    }
}

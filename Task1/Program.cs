using System.Runtime.InteropServices;
using Task1;

var student=new Student("Sam","ulica Lohuti"); 
student.AddCourse("C++",100); 
student.AddCourse("HTML",95); 
student.AddCourse("CSS",90);
student.AddCourse("C#",85);
student.AddCourse(".Net",88); 
student.PrintGrades(); 
System.Console.WriteLine(); 
System.Console.WriteLine("Average grade of student is: "+student.GetAverageGrade());  

var teacher=new Teacher("Joseph","Ulica Karamova");  
teacher.AddCourse("C++"); 
teacher.AddCourse("C#"); 
 System.Console.WriteLine(teacher.ToString()); 
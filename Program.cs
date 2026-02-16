using System;

class Student
{
    public string Name = "";
    public string Major ="";

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and my major is {Major} .");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Rachel Vasquez";
        student1.Major = "Information Technology";

        student1.Introduce();
    }
}
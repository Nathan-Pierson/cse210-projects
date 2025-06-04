using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Sam", "Math");
        string summary = a.GetSummary();
        Console.WriteLine(summary);

        MathAssignment m = new MathAssignment("Sam", "Algebra", "Section 8.5", "Problems 2-8");
        string homeworkList = m.GetHomeworkList();
        Console.WriteLine(homeworkList);

        WritingAssignment w = new WritingAssignment("Sam", "History", "The Death of Hitler");
        string WritingAssignment = w.getWritingInformation();
        Console.WriteLine(WritingAssignment);
    }
}
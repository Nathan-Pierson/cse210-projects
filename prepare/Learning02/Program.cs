using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._companyName = "BYU-Idaho";
        job1._jobTitle = "Janitor";
        job1._startYear = 2021;
        job1._endYear = 2023;

        job1.Display();

        Job job2 = new Job();
        job2._companyName = "Walmart";
        job2._jobTitle = "Cap 2";
        job2._startYear = 2020;
        job2._endYear = 2025;

        job2.Display();


        Resume myResume = new Resume();

        myResume._name = "Nathan Pierson";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }


}
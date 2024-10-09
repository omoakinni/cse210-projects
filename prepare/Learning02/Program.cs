using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("############ Learning Activity W02 #############");
        Console.WriteLine("------------------------------------------------");

        Job job1 = new Job();
        job1._jobTitle = "Frontend Developer";
        job1._companyName = "Arie Tech";
        job1._startYear= 2019;
        job1._endYear= 2021;

        Job job2 = new Job();
        job2._jobTitle = "Development Team Lead";
        job2._companyName = "NewLab";
        job2._startYear = 2018;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._personName = "Akinlolu Ariyo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("############ Learning Activity W02 #############");
    }
}
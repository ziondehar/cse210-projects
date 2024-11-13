using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        
        job1._jobTitle = "Software Developer";
        job1. _company = "Microsoft";
        job1. _startYear = 2023;
        job1. _endYear = 2024 ;

        job2._jobTitle = "Supervisor";
        job2. _company = "Apple";
        job2. _startYear = 2023;
        job2. _endYear = 2024 ;

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "kyle";
        resume1. _jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}
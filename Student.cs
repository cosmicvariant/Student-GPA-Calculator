using System;
using System.Collections.Generic;

internal class Student
{
    public string Name { get; set; }
    public List<ClassInfo> Classes { get; set; }

    public Student(string name)
    {
        Name = name;
        Classes = new List<ClassInfo>();
    }

    public void AddClass(string className, double grade, int creditHours)
    {
        Classes.Add(new ClassInfo(className, grade, creditHours));
    }

    public double CalculateGPA()
    {
        double totalQualityPoints = 0;
        int totalCreditHours = 0;

        foreach (var classInfo in Classes)
        {
            totalQualityPoints += classInfo.Grade * classInfo.CreditHours;
            totalCreditHours += classInfo.CreditHours;
        }

        return totalQualityPoints / totalCreditHours;
    }
}

internal class ClassInfo
{
    public string ClassName { get; set; }
    public double Grade { get; set; }
    public int CreditHours { get; set; }

    public ClassInfo(string className, double grade, int creditHours)
    {
        ClassName = className;
        Grade = grade;
        CreditHours = creditHours;
    }
}



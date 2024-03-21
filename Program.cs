class Program
{
    static void Main()
    {
        // Create a new student
        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();
        Student student = new Student(studentName);

        
        Console.Write("Enter the number of classes: ");
        int numberOfClasses = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfClasses; i++)
        {
            Console.WriteLine($"\nClass {i + 1}:");
            Console.Write("Enter class name: ");
            string className = Console.ReadLine();
            Console.Write("Enter grade: ");
            
            Console.Write("Enter credit hours: ");
            int creditHours = int.Parse(Console.ReadLine());

            student.AddClass(className, grade, creditHours);
        }

        // Calculate and display GPA
        double gpa = student.CalculateGPA();
        Console.WriteLine($"\nStudent Name: {student.Name}");
        Console.WriteLine("Class Information:");
        foreach (var classInfo in student.Classes)
        {
            Console.WriteLine($"- {classInfo.ClassName}: Grade {classInfo.Grade}, Credit Hours {classInfo.CreditHours}");
        }
        Console.WriteLine($"Overall GPA: {gpa:F2}");
    }
}


public class Student
{
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
    public string Name
    {
        get;
        set;
    }
    public int Grade
    {
        get;
        set;
    }
}



class Program
{
    static List<Student> students = new();
    // Menu Function
    static int Menu()
    {
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. List All Students");
        Console.WriteLine("3. Calculate Average");
        Console.WriteLine("4. Exit");
        Console.Write("Select an option: ");
        string input = Console.ReadLine();
        while (true)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                Console.Write("Select an option: ");
                input = Console.ReadLine();
            }
        }
        return Convert.ToInt32(input);
    }

    // Add Student Function
    static void AddStudent()
    {
        Console.WriteLine("Enter Student Name: ");
        string name = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid name. Please enter a valid name.");
            Console.WriteLine("Enter Student Name: ");
            name = Console.ReadLine();
        }
        Console.WriteLine("Enter Student Grade(0-100): ");
        int grade = Convert.ToInt32(Console.ReadLine());
        while (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
            Console.WriteLine("Enter Student Grade(0-100): ");
            grade = Convert.ToInt32(Console.ReadLine());
        }
        Student s = new Student(name, grade);
        students.Add(s);
        Console.WriteLine("Student added successfully.");
        Console.WriteLine("===============================================================");
    }
    static void ListAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            Console.WriteLine("===============================================================");
            return;
        }
        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
        }
        Console.WriteLine("===============================================================");
    }
    static void CalculateAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            Console.WriteLine("===============================================================");
            return;
        }
        double average = students.Average(s => s.Grade);
        Console.WriteLine($"Average Grade: {average}");
        Console.WriteLine("===============================================================");
    }
    static void Main(string[] args)
    {
        int x = 1;
        while (x == 1)
        {
            int option = Menu();
            switch (option)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ListAllStudents();
                    break;
                case 3:
                    CalculateAverage();
                    break;
                case 4:
                    x = 0;
                    Console.WriteLine("Thank You");
                    break;
            }
        }
    }
}

static int Menu()
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. List All Students");
    Console.WriteLine("3. Count Average");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option: ");
    string input = Console.ReadLine();
    while (true)
    {
        if(input == "1" || input == "2" || input == "3" || input == "4")
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

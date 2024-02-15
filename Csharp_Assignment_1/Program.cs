namespace Csharp_Assignment_1;

class Program
{
    static void Main(string[] args)
    {
        //Patient patient = new Patient("John", "Doe", 70, 180);
        //Console.WriteLine(patient.CalculateBloodPressure(125, 81));
        //Console.WriteLine(patient.BMI());
        Console.WriteLine("Please type your information");
        Console.Write("Your Birth Year: ");
        int birthYear = int.Parse(Console.ReadLine());

        Console.Write("First Name: ");
        string firstname = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastname = Console.ReadLine();

        Console.Write("Weight: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("SYSTOLIC mm Hg (upper number): ");
        int systolic = int.Parse(Console.ReadLine());

        Console.Write("DIASTOLIC mm Hg (upper number): ");
        int diastolic = int.Parse(Console.ReadLine());

        Patient patient = new Patient(firstname, lastname, weight, height);

        Console.WriteLine("\n");
        Console.WriteLine("Your healthy check result is as below: ");

        Console.WriteLine("Age: " + Patient.CalculateAge(birthYear));
        patient.ShowInformation(systolic, diastolic);
    }
}


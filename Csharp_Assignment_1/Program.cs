namespace Csharp_Assignment_1;

class Program
{
    static void Main(string[] args)
    {
        Patient patient = new Patient("John", "Doe", 70, 180);
        Console.WriteLine(patient.CalculateBloodPressure(125, 81));
        Console.WriteLine(patient.BMI());
        patient.ShowInformation();
    }
}


using System;
namespace Csharp_Assignment_1
{
	public class Patient
	{
        private string firstName;
        private string lastName;
        private double weight;
        private double height;

        public Patient(string firstName, string lastName, double weight, double height)
		{
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.height = height;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }

        //public string FirstName { get; set; }  // First Name
        //public string LastName { get; set; }   // Last Name
        //public double Weight { get; set; }     // Weight in KG
        //public double Height { get; set; }     // Height in Centimetres

        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 120 && diastolic < 80)
            {
                return "NORMAL";
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                return "ELEVATED";
            }
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if ((systolic > 180) || (diastolic < 120))
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else {
                return "Please type your systolic and diastolic again.";
            }
        }

        public double BMI() {

            double result;
            result = weight / ((height / 100) * (height / 100));
            return result;
        }

        public static int CalculateAge(int birthYear) {
            int age = 2024 - birthYear;
            return age;
        }

        public void ShowInformation(int systolic, int diastolic) {
           
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
            Console.WriteLine("Weight: " + weight + " kg");
            Console.WriteLine("Height: " + height + " cm");
            Console.WriteLine("Blood Prssure Status: " + CalculateBloodPressure(systolic, diastolic));
            //Console.WriteLine(BMI());
            string bmiStatus = "Underweight";
            if (BMI() >= 25.0) {
                bmiStatus = "Overweight";
            }else if((BMI() >= 18.5) && (BMI() <= 24.9)) {
                bmiStatus = "Normal";
            }
            Console.WriteLine("BMI Status: " + bmiStatus);
        }
    }


}


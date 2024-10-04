//Dessa Shapiro
//IGME 201
//Due: 10/13
namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initalizing varables for student,  average anbd grade array
            string student = "Dessa";
            float average = 0;
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            //welocmes student
            Console.WriteLine("Welcome to your student portal " + student + "!");
            Console.WriteLine("Here are your grades: ");
            //for loop to go through every grade
            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
                Console.WriteLine(grades[i]);

                //has a nested if statement to check if 100
                if (grades[i] >= 90 && grades[i] <= 100)
                {
                    Console.WriteLine("This Grade is an A");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! a perfect score");
                    }
                }
                else if (grades[i] >= 80 && grades[i] <= 89)
                {
                    Console.WriteLine("This Grade is a B");
                }
                else if (grades[i] >= 70 && grades[i] <= 79)
                {
                    Console.WriteLine("This Grade is a C");
                }
                else if (grades[i] >= 70 && grades[i] <= 79)
                {
                    Console.WriteLine("This Grade is a C");
                }
                else if (grades[i] >= 65 && grades[i] <= 69)
                {
                    Console.WriteLine("This Grade is a D");
                }
                else if (grades[i] >= 0 && grades[i] <= 64)
                {
                    Console.WriteLine("This Grade is an F");
                }
                //last condition of code
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");

                }
            }
            //calculates avaerage
            average /= grades.Length;
            //writes final statments 
            Console.WriteLine("Your grade average is: "+average);
            Console.WriteLine("We have shown all the grades for " + student);
        }
       

    }
}

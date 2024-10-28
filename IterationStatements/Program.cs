using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void PrintNumber(int number)
        {
            //number = 1000;
            //for (int i = 1; i <= number; i++)
            while (number >= -1000)
            {
                Console.WriteLine(number);
                number -= 1;
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        static void PrintEveryThirdNumber(int thirdNumber)
        {

            for (int i = 3; i <= thirdNumber; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        static void AreNumbersEqual(int sameNumberOne, int sameNumberTwo)
        {
            if (sameNumberOne == sameNumberTwo)
            {
                Console.WriteLine("They are equal");
            }
            else if (sameNumberOne != sameNumberTwo)
            {
                Console.WriteLine("They are not equal");
            }
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        static void IsEven(int isItEven)
        {
            if (isItEven % 2 == 0)
            {
                Console.WriteLine($"{isItEven} is even");
            }
            else if (isItEven % 2 != 0)
            {
                Console.WriteLine($"{isItEven} is odd, not even");
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        static void negativeCheck(int IsPosOrNeg)
        {
            if (IsPosOrNeg > 0)
            {
                Console.WriteLine($"{IsPosOrNeg} is positive");
            }
            else if (IsPosOrNeg < 0)
            {
                Console.WriteLine($"{IsPosOrNeg} is negative");
            }
            else if (IsPosOrNeg == 0)
            {
                Console.WriteLine($"{IsPosOrNeg} is neither positive nor negative");
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        static void CanVote()
        {
            Console.WriteLine("In order to vote you must enter your age:");
            int votingAge = 18;
            string userInput = Console.ReadLine();
            Console.WriteLine($"You have said your age {userInput}.");
            if (int.TryParse(userInput, out int age))
            {
                if (age >= votingAge)
                {
                    Console.WriteLine($"You are allowed to vote!");
                }
                else if (age <= votingAge)
                {
                    Console.WriteLine($"You are {age} which is too young to vote!");
                }
            }
            else
            {
                    Console.WriteLine($"Please enter a valid number!");
                    CanVote(); 
            }
            
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        static void IsInRange()
        {
            bool isInRange = false;
            Console.WriteLine("Type out a number:");
            string ? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int number))
            {
                // if (number >= -10 && number <= 10)
                // {
                //     Console.WriteLine($"{number} is is within my range");
                //     isInRange = true;
                // }
                // else if (number <= -10 || number >= 10)
                // {
                //     Console.WriteLine($"{number} is outside the range");
                // }
                if (number < -10 || number > 10)
                {
                    Console.WriteLine($"{number} is not within my range");
                    isInRange = false;
                }
                else
                {
                    Console.WriteLine($"{number} is is within my range");
                    isInRange = true;
                }
                
            }
            else
            {
                Console.WriteLine($"Please enter a valid number!");
               IsInRange(); 
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        static void DisplayMultiplicationTable(int number)
        {
            //Console.WriteLine($"Multiplication table\nPlease enter a number from 1 to 12 to calculate the multiplication table:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            PrintNumber(1000);
            PrintEveryThirdNumber(999);
            AreNumbersEqual(20,20);
            IsEven(21);
            negativeCheck(-0);
            CanVote();
            IsInRange();
            DisplayMultiplicationTable(165);
        }
    }
}

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 500;

            int anotherNumber = 3500;

            //celebrityChef = "Padma Lakshmi"
            //Console.WriteLine(celebrityChef)


            string celebrityChefs = "Padma Lakshmi";
            char someCharacter = '$';
            bool canCook = true;
            int firstNumber = 5;
            double secondNumber = 22.4;
            decimal thirdNumber = 503.1m;

            Console.WriteLine($"My favorite celebrity chef is {celebrityChefs}. She cooks {firstNumber} meals a day");
            Console.WriteLine($"She jogs {secondNumber} miles to burn off all of those calories");
            Console.WriteLine($"Her favorite dish to cook is Hariyali Chicken, and if you lined all those dishes on the ground it would stretch {thirdNumber} miles");
            Console.WriteLine($"It's crazy but {canCook}");
            Console.WriteLine($"She charges {someCharacter}{number} for a cameo and {someCharacter}{anotherNumber} for a public appearence");

        }
    }
}

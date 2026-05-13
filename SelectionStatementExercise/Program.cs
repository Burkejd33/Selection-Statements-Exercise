namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favnumber = 3;
            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < favnumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favnumber)
            {
                Console.WriteLine("too high.");
            }
            else 
            {
                Console.WriteLine("You Guessed it");
            }
           Console.WriteLine("Press any key to continue . . .");
           Console.ReadKey();
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            switch (favoriteSubject)
            {
            case "Math":
                Console.WriteLine("So you like problem solving");
                break;
            case "Science":
                Console.WriteLine("So you like asking questions");
                break;
            case "History":
                Console.WriteLine("So you like knowing about our past");
                break;
            case "English":
                Console.WriteLine("So you like to follow the rules");
                break;
            case "Art":
                Console.WriteLine("So you are creatvie");
                break;
            case "PE":
                Console.WriteLine("So you like sports");
                break;
            default:
                Console.WriteLine("Interesting choice! I never would have guessed that!");
                break;
            }
        }
    }
}
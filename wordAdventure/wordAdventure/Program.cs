using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {

        int Z = 0;
        int X = 0;
        int Y = 0;
        int B = 0;
        while (Z != 1)
        {


            Console.Write("Please enter 1, 2, or both: ");
            string UserInput = Console.ReadLine();


            //string stringToSeek = UserInput;
            char character1 = '1';
            char character2 = '2';



            bool result1;

            result1 = UserInput.Contains(character1);

            bool result2;

            result2 = UserInput.Contains(character2);

            if (result1 == true)
            {
                X = 1;
            }

            if (result2 == true)
            {
                Y = 2;
            }

            if ((X == 1) && (Y == 2))
            {
                Console.WriteLine("Wow, someone's greedy!");
            }

            else if ((X == 1) || (Y == 2))
            {
                Console.WriteLine("Just picked one?");
            }

            else
            {
                Console.WriteLine("");
            }

            if ((X == 1) && (Y == 0))
            {
                Console.WriteLine("You have chosen Path 1.");
                B = 1;
                Z = 1;
            }

            else if ((X == 0) && (Y == 2))
            {
                Console.WriteLine("You have chosen Path 2.");
                B = 2;
                Z = 1;

            }

            else if ((X == 1) && (Y == 2))
            {
                Console.WriteLine("You have chosen the hidden Path 3");
                B = 3;
                Z = 1;
            }

            else
            {
                Console.WriteLine("Please try selecting again.");
            }





        }

        if (B == 1)
        {
            Console.WriteLine("You see a large man down Path 1...");
        }

        else if (B == 2)
        {
            Console.WriteLine("You see two small men down Path 2...");
        }

        else if (B == 3)
        {
            Console.WriteLine("How did you get on this path?");
        }

        Console.WriteLine("This is the end of the adventure for now...");



    }


}
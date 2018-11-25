using System;
namespace SlotMachine
{
    class SlotMachine
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st symbol: ");
                char charFirstPair = char.Parse(Console.ReadLine());                  
                while (charFirstPair < ' ' || charFirstPair > '~')
                {
                    Console.Write("Invalid input. Try again! Keep in mind that " +
                            "the position of the 1st symbol in the ASCII table could be from 32 to 126: ");
                    charFirstPair = char.Parse(Console.ReadLine());
                }

                Console.Write("Enter 1st integer: ");
                int intFirstPair = int.Parse(Console.ReadLine());          
                while (intFirstPair < 1 || intFirstPair > 93)
                {
                    Console.Write("Invalid input. Try again! Keep in mind that " +
                            "the integer must be in the range from 1 to 93: ");
                    intFirstPair = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter 2nd symbol: ");
                char charSecondPair = char.Parse(Console.ReadLine());                  
                while (charSecondPair < ' ' || charSecondPair > '~')
                {
                    Console.Write("Invalid input. Try again! Keep in mind that " +
                            "the position of the 1st symbol in the ASCII table could be from 32 to 126: ");
                    charSecondPair = char.Parse(Console.ReadLine());
                }

                Console.Write("Enter 2nd integer: ");
                int intSecondPair = int.Parse(Console.ReadLine());          
                while (intSecondPair < 1 || intSecondPair > 93)
                {
                    Console.Write("Invalid input. Try again! Keep in mind that " +
                            "the integer must be in the range from 1 to 93: ");
                    intSecondPair = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter 3rd symbol: ");
                char charThirdPair = char.Parse(Console.ReadLine());                  
                while (charThirdPair < ' ' || charThirdPair > '~')
                {
                    Console.Write("Invalid input. Try again! Keep in mind that " +
                            "the position of the 1st symbol in the ASCII table could be from 32 to 126: ");
                    charThirdPair = char.Parse(Console.ReadLine());
                }

                Console.Write("Enter 3rd integer: ");
                int intThirdPair = int.Parse(Console.ReadLine());          
                while (intThirdPair < 1 || intThirdPair > 93)
                {
                    Console.Write("Invalid input. Try again! Keep in mind that " +
                            "the integer must be in the range from 1 to 93: ");
                    intThirdPair = int.Parse(Console.ReadLine());
                }

                int sumInFirstPair = (int)charFirstPair + intFirstPair;              
                int sumInSecondPair = (int)charSecondPair + intSecondPair;              
                int sumInThirdPair = (int)charThirdPair + intThirdPair;              

                char combinationFirstPair = (char)sumInFirstPair;                
                char combinationSecondPair = (char)sumInSecondPair;                
                char combinationThirdPair = (char)sumInThirdPair;                

                if (combinationFirstPair == '7' && combinationSecondPair == '7' && combinationThirdPair == '7')
                {                          //case win
                    Console.WriteLine("777\n*** JACKPOT ***\n");
                }
                else if (combinationFirstPair == '@' && combinationSecondPair == '@' && combinationThirdPair == '@')
                {                   //case lose
                    Console.WriteLine("@@@\n!!! YOU LOSE EVERYTHING !!!\n");
                }
                else
                {                                                            //all the rest cases
                    Console.Write(combinationFirstPair);
                    Console.Write(combinationSecondPair);
                    Console.WriteLine(combinationThirdPair);
                }

            }
            catch
            {
                Console.WriteLine("Invalid input! Please, start from the beginning!");
            }
        }
    }
}
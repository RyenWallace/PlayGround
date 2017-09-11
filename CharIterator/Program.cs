using System;

namespace CharIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //check that input can be converted to char
                var charVal = Convert.ToChar(args[0]);

                //Check that input is a character
                if (char.IsLetter(charVal))
                {
                    //Get Next Character
                    char charToUse = IncrementCharacter(charVal);
                    
                    //Write the next characters in the set
                    for (char letter = charToUse; letter <= 'Z'; letter++)
                    {
                        Console.WriteLine(letter);
                    }
                }
                else
                {
                    Console.WriteLine("Input was not valid");
                }
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }

        private static char IncrementCharacter(char input)
        {
            return (input == 'z' ? 'a' : (char)(input + 1));
        }
    }
}

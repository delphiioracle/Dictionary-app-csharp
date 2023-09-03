using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static List<string> words = new List<string>();
    private static string word;
    
    static void Main(string[] args)
    {
        Menu();
    }            
    public static void Menu()
    {
            {
                Console.WriteLine("\n\n=====================");
                Console.WriteLine("Menu of the Dictionary");
                Console.WriteLine("Welcome to my app");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Edit");
                Console.WriteLine("4. View");
                Console.WriteLine("5. Search");
                Console.WriteLine("Please enter an option:");
                var option = Console.ReadLine();
                // depending on the option, we will do different things.
                if (option == "1")
                {
                    ShowAddScreen();
                    Menu();
                }
                
            
            }
    }
    public static void ShowAddScreen()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("[[ADDING A NEW WORD]]");    
        Console.WriteLine("Add a new word: ");
        string newWord = Console.ReadLine();

        Console.WriteLine("What's the meaning of the word: ");
        string meaningOfTheWord = Console.ReadLine();

        string word = "NewWord =  " + newWord + "MeaningOfTheWord = " + meaningOfTheWord;
        words.Add(word);

    }

    

   }

}
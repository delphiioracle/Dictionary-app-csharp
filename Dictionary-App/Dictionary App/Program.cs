using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static Dictionary<string, string> DictionaryApp = new();

    private static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("\n\n=====================");
            Console.WriteLine("Menu of the Dictionary app");
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

            }

        } while (true);
    }

    public static void SaveInformation(string newWord, string meaningOfTheWord)
    {

    }

    public static void ShowAddScreen()
    {
        Console.WriteLine("[[ADDING A NEW WORD]]");
        Console.WriteLine("Add a new word: ");
        var newWord = Console.ReadLine();

        Console.WriteLine("What's the meaning of the word: ");
        var meaningOfTheWord = Console.ReadLine();

        DictionaryApp.Add(newWord, meaningOfTheWord);

      
       ( "eat": "to consume something solid or semi-solid, usually food through the mouth"),
       ( "drink": "to consume liquid through the mouth" );

        string eat = "none";
        if (newWord. (eat, out eat))
            (
                Console.WriteLine("Found value: " + eat);
        ShowAddScreen();
        
        
        
    }


    }





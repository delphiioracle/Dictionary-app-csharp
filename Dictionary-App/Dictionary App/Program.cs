using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Titi
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

        DictionaryApp.Add(newWord!, meaningOfTheWord!);


        ShowAddScreen();



    }



    static void DeleteInformation(string deletingWord)

    {

    }

    void ShowDeleteScreen(object deleteWord)
        
    {

        Console.WriteLine("=============================");
        Console.WriteLine("[[DELETING A WORD]]");
        Console.WriteLine("[[Delete a word: ]]");
        var deleteWord = Console.ReadLine();

        Console.WriteLine("delete information about a word");
        var deleteInformation = Console.ReadLine();


        DictionaryApp.Remove(deleteWord, DeleteInformation);

        ShowDeleteScreen();
    



}

    void ShowDeleteScreen()
    {

    }
}
﻿using System.ComponentModel.Design;
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
            switch (option)
            {
                case "1":
                    ShowAddScreen();
                    break;
                case "2":
                    ShowDeleteScreen();
                    break;
                default:
                    break;

            }



        }
    }
    public static void ShowAddScreen()
    {
        string newWord = "";
        while (string.IsNullOrWhiteSpace(newWord))
        {
            Console.WriteLine("[[ADDING A NEW WORD");
            Console.WriteLine("Add a new word: ");
            newWord = Console.ReadLine();
        }
        string meaningOfTheWord = "";
        while (string.IsNullOrWhiteSpace(meaningOfTheWord))
        {
            Console.WriteLine("What is the meaning of the word: ");
            meaningOfTheWord = Console.ReadLine();
        }

        DictionaryApp.Add(newWord, meaningOfTheWord);

        ShowAddScreen();

        static void DeleteInformation(string deletingWord)
        {

        }

        static void ShowDeleteScreen()
        {
            Console.WriteLine("[[DELETING A WORD]]");
            Console.WriteLine("[[Delete a word: ]]");
            string deleteWord = Console.ReadLine();

            DictionaryApp.Remove(deleteWord);

            ShowDeleteScreen();
        }


    }
}


    





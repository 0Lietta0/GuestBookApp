using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook;

public static class GuestListLogic
{

    public static void WelcomeToApp()
    {
        Console.WriteLine("Welcome to the \"GuestBookApp\"!");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }
    public static (string partyName, int partySize) GetPartyInfo()
    {
        string? readResult = "";
        string partyName = "";
        int partySize = 0;

        Console.Clear();


        do
        {
            Console.Write($"Write your party/group name: ");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                partyName = readResult.Trim();
                if (partyName == "")
                {
                    Console.WriteLine("You haven't entered a name. Try again.");
                }
            }
        } while (partyName == "");

        do
        {
            Console.Write($"How many people are in the party: ");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if (int.TryParse(readResult, out partySize) == false)
                {
                    Console.WriteLine("This is not a digit numer. Try again.");
                }
                else if (partySize > 10)
                {
                    Console.WriteLine("There can be a maximum of 10 people in a group. You must split into more groups.");
                }
            }
        } while (partySize <= 0 || partySize > 10);

        return (partyName, partySize);
    }
    public static List<string> AddToGuestList(List<string> guestList, string partyName, int partySize)
    {
        guestList.Add($"{partyName} - {partySize}" + (partySize == 1 ? "guest" : "guests"));

        return guestList;
    }
    public static int IncreaseGuestNumber(int guestCount, int guestToAdd)
    {
        guestCount += guestToAdd;

        return guestCount;
    }
    public static void PrintGuestList(List<string> guestList, int guestCount)
    {
        Console.Clear();
        Console.WriteLine($"The Guest Book:");
        foreach (string partyInfo in guestList)
        {
            Console.WriteLine(partyInfo);
        }
        Console.WriteLine();
        Console.WriteLine($"The event was attended by a total of {guestCount} guests.");
    }
    public static bool WantsToProceed()
    {
        string? readResult = null;
        bool wantsToProceed = false;

        do
        {
            Console.WriteLine("\nType \"next\" to continue adding guests.");
            Console.WriteLine("Type \"end\" at the end of the event.");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                readResult = readResult.Trim().ToLower();
                if (readResult == "end")
                {
                    wantsToProceed = true;
                }
                else if (readResult != "next")
                {
                    Console.WriteLine("Type \"next\" or \"end\" to proceed.");
                }
            }
        } while (readResult != "next" && readResult != "end");

        return wantsToProceed;
    }
}

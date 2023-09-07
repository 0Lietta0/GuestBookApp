﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook;

public static class GuestList
{

    public static void WelcomeToApp()
    {
        Console.WriteLine("Welcome to the \"GuestBookApp\"!" +
            " The app designed to meet all of your guest list creation needs.");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }
    public static (string guestName, int partyNumber) GetPartyInfo()
    {
        string? readResult = "";
        string guestName = "";
        int partyNumber = 0;

        Console.Clear();


        do
        {
            Console.Write($"Write your name: ");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                guestName = readResult.Trim();
                if(guestName == "")
                {
                    Console.WriteLine("Input is incorrect. Try again.");
                }
            } 
        } while (guestName == "");

        do
        {
            Console.Write($"Write how many people are coming with you: ");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if(int.TryParse(readResult, out partyNumber) == false)
                {
                    Console.WriteLine("Input is incorrect. Try again.");
                }
            }
        } while (partyNumber <= 0);

        return (guestName, partyNumber);
    }
    public static List<string> AddToGuestList(List<string> guestList,string guestName)
    {
        guestList.Add(guestName);

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
        foreach (string guestName in guestList)
        {
            Console.WriteLine(guestName);
        }
        Console.WriteLine();
        Console.WriteLine($"The event will be attended by {guestCount} guests.");
    }
    public static bool WantsToProceed()
    {
        string? readResult = null;
        bool wantsToProceed = false;

        do
        {
            Console.WriteLine("\nPress enter to add more guests or " +
            "type: \"next\" when adding guests is finished" +
            "and you are ready to proceed to the guestbook.\n");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                readResult = readResult.Trim().ToLower();
                if (readResult == "next")
                {
                    wantsToProceed = true;
                }
            else if (readResult != "")
                {
                    Console.WriteLine("\nThat was invalid input. Try one more time.");
                }
            } 
        } while (readResult != "" && readResult != "next");

        return wantsToProceed;
    }
}

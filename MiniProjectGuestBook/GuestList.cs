using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook;

public static class GuestList
{
    public static (string guestName, int partyNumber) GetPartyInfo()
    {
        string? readResult = "";
        string guestName = "";
        int partyNumber = 0;
        Console.Write($"Write your name: ");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            guestName = readResult.Trim();
        }
        Console.Write($"Write how many people are coming with you: ");
        if (readResult != null)
        {
            int.TryParse(readResult, out partyNumber);
        }

        return (guestName, partyNumber);
    }
    public static List<string> AddToGuestList(List<string> guestList,string guestName)
    {
        guestList.Add(guestName);

        return guestList;
    }
    public static int IncreaseGuestNumber(int guestCount, int guestAdded)
    {
        guestCount += guestAdded;

        return guestCount;
    }
    public static void PrintGuestList(List<string> guestList, int guestCount)
    {
        Console.WriteLine($"Guestbook: \n{guestList}\n");
        Console.WriteLine($"The event will be attended by {guestCount} guests.");
    }
}

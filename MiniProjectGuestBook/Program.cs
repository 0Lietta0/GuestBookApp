
using MiniProjectGuestBook;
List<string> guestList = new List<string>();
int guestCount = 0;
bool wantsToProceed = false;

GuestList.WelcomeToApp();

do
{
    (string guestName, int partySize) = GuestList.GetPartyInfo();
    GuestList.AddToGuestList(guestList, guestName);
    guestCount = GuestList.IncreaseGuestNumber(guestCount, partySize);
    wantsToProceed = GuestList.WantsToProceed();

} while (wantsToProceed == false) ;

GuestList.PrintGuestList(guestList, guestCount);

Console.ReadLine();
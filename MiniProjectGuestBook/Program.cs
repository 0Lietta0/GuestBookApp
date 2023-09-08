
using MiniProjectGuestBook;
List<string> guestList = new List<string>();
int guestCount = 0;
bool wantsToProceed = false;

GuestListLogic.WelcomeToApp();

do
{
    (string guestName, int partySize) = GuestListLogic.GetPartyInfo();
    GuestListLogic.AddToGuestList(guestList, guestName, partySize);
    guestCount = GuestListLogic.IncreaseGuestNumber(guestCount, partySize);
    wantsToProceed = GuestListLogic.WantsToProceed();

} while (wantsToProceed == false) ;

GuestListLogic.PrintGuestList(guestList, guestCount);

Console.ReadLine();
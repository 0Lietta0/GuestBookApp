
using MiniProjectGuestBook;
List<string> guestList = new List<string>();
int guestCount = 0;
bool wantsToProceed = false;

do
{
    (string guestName, int partySize) = GuestList.GetPartyInfo();
    GuestList.AddToGuestList(guestList, guestName);
    GuestList.IncreaseGuestNumber(guestCount, partySize);
    GuestList.WantsToProceed();

} while (wantsToProceed == false) ;

GuestList.PrintGuestList(guestList, guestCount);
using Library_Management_System___Modified__;

BookManager bookManager = new BookManager();
MemberManager memberManager = new MemberManager();
IFineCalculator fineCalculator = new FineCalculator();

Library library = new Library(
    bookManager,
    memberManager,
    fineCalculator
);

Menu menu = new Menu();

while (true)
{
    menu.ShowMainMenu();

    int choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            // librarian menu
            menu.ShowLibrarianMenu();
            break;

        case 2:
            // member menu
            menu.ShowMemberMenu();
            break;

        case 3:
            return;
    }
}
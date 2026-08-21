using Library_Management_System__Practice_;

Console.WriteLine();
BorrowRecordManager borrowManager = new BorrowRecordManager();
MemberManager memberManager = new MemberManager();
BookManager bookManager = new BookManager();
Library library = new Library(borrowManager, memberManager,bookManager);
Menu menu = new Menu();



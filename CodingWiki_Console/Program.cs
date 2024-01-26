// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

////using (ApplicationDbContext context = new())
////{
////    context.Database.EnsureCreated();
////    if(context.Database.GetPendingMigrations().Count() > 0)
////    {
////        context.Database.Migrate();
////    }

////}

////AddBooks();
//GetAllBooks();
//GetBook();
//DeleteBook();


//async void DeleteBook()
//{
//    using var context = new ApplicationDbContext();
//    var book = await context.Books.FindAsync(1003);
//    context.Books.Remove(book);
//    await context.SaveChangesAsync();
//}


//void GetBook()
//{
//    try
//    {
//        using var context = new ApplicationDbContext();
//        var books = context.Books.Where(u => u.Publisher_Id == 3);
//        //Console.WriteLine(book.Title + " - " + book.ISBN);

//        foreach (var book in books)
//        {
//            Console.WriteLine(book.Title + " - " + book.ISBN);
//        }
//    }
//    catch (Exception e)
//    {

//    }
//}
//void GetAllBooks()
//{
//    using var context = new ApplicationDbContext();
//    var books = context.Books.ToList();

//    foreach(var book in books)
//    {
//        Console.WriteLine(book.Title+ " - " + book.ISBN);
//    }
//}

//async void AddBooks()
//{
//    Book book = new() { Title = "New Teste01", ISBN = "124545454", Price = 10.93m, Publisher_Id = 1 };
//    using var context = new ApplicationDbContext();
//    var books = context.Books.Add(book);
//    await context.SaveChangesAsync();
//}
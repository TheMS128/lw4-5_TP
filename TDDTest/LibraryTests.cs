using NUnit.Framework;
using TDDTest.Library.Model;

namespace TDDTest;

public class LibraryTests
{
    [Test]
    public void Library_Should_Add_Books()
    {
        var library = new Library.Model.Library();
        var book = new Book("C# in Depth", "Jon Skeet", 2019);
        library.AddBook(book);

        Assert.That(library.GetBooks().Count, Is.EqualTo(1));
    }

    [Test]
    public void Library_Should_Find_Book_By_Title()
    {
        var library = new Library.Model.Library();
        var book = new Book("C# in Depth", "Jon Skeet", 2019);
        library.AddBook(book);
        var foundBook = library.FindBookByTitle("C# in Depth");

        Assert.That(foundBook.Author, Is.EqualTo("Jon Skeet"));
    }

    [Test]
    public void Library_Should_Remove_Book()
    {
        var library = new Library.Model.Library();
        var book = new Book("C# in Depth", "Jon Skeet", 2019);
        library.AddBook(book);
        library.RemoveBook(book);

        Assert.That(library.GetBooks().Count, Is.EqualTo(0));
    }
    
    [Test]
    public void Library_Should_Find_Books_By_Author()
    {
        var library = new Library.Model.Library();
        var book1 = new Book("C# in Depth", "Jon Skeet", 2019);
        var book2 = new Book("Effective C#", "Bill Wagner", 2017);
        library.AddBook(book1);
        library.AddBook(book2);
        var booksByAuthor = library.FindBooksByAuthor("Jon Skeet");

        Assert.That(booksByAuthor.Count, Is.EqualTo(1));
        Assert.That(booksByAuthor[0].Title, Is.EqualTo("C# in Depth"));
    }
    
    [Test]
    public void Library_Should_Return_All_Books()
    {
        var library = new Library.Model.Library();
        var book1 = new Book("C# in Depth", "Jon Skeet", 2019);
        var book2 = new Book("Effective C#", "Bill Wagner", 2017);
        library.AddBook(book1);
        library.AddBook(book2);
        var books = library.GetBooks();

        Assert.That(books.Count, Is.EqualTo(2));
    }
}
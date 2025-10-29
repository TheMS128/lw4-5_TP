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
}
using TDDTest.Library.Model;
using NUnit.Framework;

namespace TDDTest;

public class BookTests
{
    [Test]
    public void Book_Should_Have_A_Title()
    {
        var book = new Book("C# in Depth", "Jon Skeet", 2019);
        var title = book.Title;

        Assert.That(title, Is.EqualTo("C# in Depth"));
    }

    [Test]
    public void Book_Should_Have_A_Author()
    {
        var book = new Book("C# in Depth", "Jon Skeet", 2019);
        var author = book.Author;

        Assert.That(author, Is.EqualTo("Jon Skeet"));
    }

    [Test]
    public void Book_Should_Have_A_Year()
    {
        var book = new Book("C# in Depth", "Jon Skeet", 2019);
        var year = book.Year;

        Assert.That(year, Is.EqualTo(2019));
    }
    
    [Test]
    public void Library_Should_Not_Add_Duplicate_Books()
    {
        var library = new Library.Model.Library();
        var book1 = new Book("C# in Depth", "Jon Skeet", 2019);
        var book2 = new Book("C# in Depth", "Jon Skeet", 2019);
        library.AddBook(book1);
        library.AddBook(book2);

        Assert.That(library.GetAllBooks().Count, Is.EqualTo(1));
    }
}
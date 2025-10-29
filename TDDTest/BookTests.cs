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
}
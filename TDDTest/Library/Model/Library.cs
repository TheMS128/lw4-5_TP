namespace TDDTest.Library.Model;

public class Library
{
    private readonly List<Book> _books = new();

    public void AddBook(Book book) => _books.Add(book);

    public IReadOnlyList<Book> GetBooks() => _books;

    public Book? FindBookByTitle(string title) => _books.Find(b => b.Title == title);

    public void RemoveBook(Book book) => _books.Remove(book);
}
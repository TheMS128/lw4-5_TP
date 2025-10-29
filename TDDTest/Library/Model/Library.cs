namespace TDDTest.Library.Model;

public class Library
{
    private readonly List<Book> _books = new();

    public void AddBook(Book book)
    {
        if (!_books.Exists(b => b.Title == book.Title && b.Author == book.Author && b.Year == book.Year)) _books.Add(book);
    }

    public IReadOnlyList<Book> GetBooks() => _books;

    public Book? FindBookByTitle(string title) => _books.Find(b => b.Title == title);

    public void RemoveBook(Book book) => _books.Remove(book);
    
    public List<Book> FindBooksByAuthor(string author)
    {
        return _books.FindAll(b => b.Author == author);
    }
}
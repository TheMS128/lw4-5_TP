namespace TDDTest.Library.Model;

public class Book {
    private string title;
    private string author;
    private int year;

    public Book(String title, String author, int year) {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public string GetTitle() {
        return title;
    }

    public string GetAuthor() {
        return author;
    }

    public int GetYear() {
        return year;
    }

    public void SetTitle(string title) {
        this.title = title;
    }

    public void SetAuthor(string author) {
        this.author = author;
    }

    public void SetYear(int year) {
        this.year = year;
    }
}

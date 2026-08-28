namespace Lesson02.Library;

public class Library
{
    private List<Book> _bookCollection;

    public Library(List<Book> bookCollection)
    {
        _bookCollection = bookCollection;
    }

    public List<Book> BookCollection
    {
        get => this._bookCollection; 
        set => this._bookCollection = value;
    }
}
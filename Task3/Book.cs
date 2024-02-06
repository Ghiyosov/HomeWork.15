namespace Task3;

public class Book : AbstractBook
{
    public override string Title { get; set; }
    public override string Author { get; set; }
    List<Book> _library = new List<Book>();
    public override void SetTitle(string title)
    {
        Title = title;
    }
    public override string GetTitle()
    {
        return Title;
    }
    public override void SetAuthor(string author)
    {
        Author = author;
    }
    public override string GetAuthor()
    {
        return Author;
    }
    public override void Read()
    {
        System.Console.WriteLine($"The book's {Title} reder");
    }
    

    public override void Borrow()
    {
        System.Console.WriteLine($"The book : {Title} has been borrowed");
    }


    public override void ReturnBook()
    {
        System.Console.WriteLine($"The book : {Title} has been returned");
    }

}

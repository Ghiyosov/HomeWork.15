namespace Task3;

public abstract class AbstractBook : IReadable , IBorrowable
{
     public abstract string Title { get; set; }
    public abstract string Author { get; set; }
    public abstract void SetTitle(string title);
    public abstract string GetTitle();
    public abstract void SetAuthor(string author);
    public abstract string GetAuthor();

    public abstract void Read();
    

    public abstract void Borrow();
 

    public abstract void ReturnBook();

}
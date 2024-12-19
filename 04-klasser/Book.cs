using System.Security.Cryptography.X509Certificates;

public class Book
{
    private string name;
    private int pages;
    private int currentPage = 0;
    public int TurnPage()
    {
        return currentPage ++;
    }

    public int GetCurrentPage()
    {
        Console.WriteLine(currentPage);
        return currentPage;
    }

    public Book(string n, int p)
    {
        name = n;
        pages = p;
    }

    public string GetName()
    {
        Console.WriteLine(name);
        return name;
    }

    public int GetPages()
    {
        Console.WriteLine(pages);
        return pages;
    }

}


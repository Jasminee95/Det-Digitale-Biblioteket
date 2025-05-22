namespace Det_Digitale_Biblioteket;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
    public int Year { get; set; }
    public bool Utleid { get; set; }

    public Book(string title, string author, string isbn, int year, bool utleid)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        Year = year;
        Utleid = false;
    }

    public void VisBokInfo()
    {
        Console.WriteLine($"{Title} som blev skrevet av {Author} ISBN: {Isbn} med utgivelseår {Year} er {(Utleid ? "utlånt" : "tilgjengelig")}.");
    }
}
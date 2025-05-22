namespace Det_Digitale_Biblioteket;

public class User
{
    public string Name { get; set; }
    public int UserId { get; set; }
    public List<Book> LånteBøker { get; set; }

    public User(string name, int userId, List<Book>liste)
    {
        Name = name;
        UserId = userId;
        LånteBøker = new List<Book>();
    }

    public void VisLånteBøker()
    {
        Console.WriteLine($"\n*** Lånte bøker av {Name} (ID: {UserId}) ***");
        if (LånteBøker.Count == 0)
        {
            Console.WriteLine($"{Name} har ikke lånt noen bøker");
        }
        else
        {
            foreach (var book in LånteBøker)
            {
                Console.WriteLine($"-{book.Title} av {book.Author} (ISBN {book.Isbn})");
            }
        }
        Console.WriteLine("**********************************");
    }
    
}
namespace Det_Digitale_Biblioteket;

public class Library
{
    public string Name { get; set; }
    public List<Book> Boksamling { get; set; }
    public List<User> RegistrerteBrukere { get; set; }

    public Library(string name)
    {
        Name = name;
        Boksamling = new List<Book>();
        RegistrerteBrukere = new List<User>();
    }

    public void LeggTilBok(Book book)
    {
        Boksamling.Add(book);
        Console.WriteLine($"{book.Title} av {book.Author} er lagt til i biblioteket.");
    }

    public void RegistrerBruker(User user)
    {
        RegistrerteBrukere.Add(user);
        Console.WriteLine($"Bruker {user.Name} (ID {user.UserId}) er registrert.");
    }

    public void LånUtBok(string isbn, int UserId)
    {
        Console.WriteLine($"\nForsøker å låne en bok med ISBN {isbn} til bruker {UserId}");
        
        Book bookToLend = Boksamling.FirstOrDefault(b => b.Isbn == isbn);
        User lendingUser = RegistrerteBrukere.FirstOrDefault(u => u.UserId == UserId);

        if (bookToLend == null)
        {
            Console.WriteLine($"Feil: Bok med ISBN {isbn} ble ikke funnet i samlingen.");
        }
        else if (lendingUser == null)
        {
            Console.WriteLine($"Feil: Bruker med ID {UserId} ble ikke funnet.");
        }
        else if (bookToLend.Utleid)
        {
            Console.WriteLine($"Feil: {bookToLend.Title} er allerede utleid");
        }
        else
        {
            bookToLend.Utleid = true;
            lendingUser.LånteBøker.Add(bookToLend);
            Console.WriteLine($"Suksess: {bookToLend.Title} lånt ut til {lendingUser.Name}.");
        }
    }

    public void LeverInnBok(string isbn, int UserId)
    {
        Console.WriteLine($"\nForsøker å levere inn bok med ISBN {isbn} av bruker {UserId}");
        
        Book bookToReturn = Boksamling.FirstOrDefault(b => b.Isbn == isbn);
        User returningUser = RegistrerteBrukere.FirstOrDefault(u => u.UserId == UserId);

        if (bookToReturn == null)
        {
            Console.WriteLine($"Feil: Bok med ISBN {isbn} ble ikke funnet i samlingen.");
        }
        else if (returningUser == null)
        {
            Console.WriteLine($"Feil: Bruker med ID {UserId} ble ikke funnet.");
        }
        else if (!bookToReturn.Utleid)
        {
            Console.WriteLine($"Feil: {bookToReturn.Title} er ikke registrert som utleid");
        }
        else if (!returningUser.LånteBøker.Contains(bookToReturn))
        {
            Console.WriteLine($"Feil: {returningUser.Name} har ikke lånt {bookToReturn.Title}.");
        }
        else
        {
            bookToReturn.Utleid = false;
            returningUser.LånteBøker.Remove(bookToReturn);
            Console.WriteLine($"Suksess: {bookToReturn.Title} levert inn av {returningUser.Name}.");
        }
    }

    public void VisAlleBøker()
    {
        Console.WriteLine("\n*** Alle bøker i biblioteket ***");
        if (Boksamling.Count == 0)
        {
            Console.WriteLine("Biblioteket har ingen bøker.");
        }
        else
        {
            foreach (var book in Boksamling)
            {
                book.VisBokInfo();
            }
        }
        Console.WriteLine("******************************");
    }
    public void VisAlleBrukere()
    {
        Console.WriteLine("\n*** Alle registrerte brukere ***");
        if (RegistrerteBrukere.Count == 0)
        {
            Console.WriteLine("Ingen brukere registrert i biblioteket.");
        }
        else
        {
            foreach (var user in RegistrerteBrukere)
            {
                Console.WriteLine($"-{user.Name} (ID {user.UserId}) er registrert.)");
            }
        }
        Console.WriteLine("******************************");
    }
}
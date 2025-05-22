using Det_Digitale_Biblioteket;

Library Biblotek = new Library("Folkebiblioteket");

Book HarryPotterogDevisesstein = new Book("Harry Potter og De vises stein", "J.K. Rowling", "978-8202170367", 1997, false);
Book RingenesHerre = new Book("Ringenes Herre", "J.R.R. Tolkien", "978-8203223049", 1954, false);
Book Sult = new Book("Sult", "Knut Hamsun", "978-8205423851", 1890, false);
Book Fugletribunalet = new Book("Fugletribunalet", "Agnes Ravatn",  "978-8249513364", 2013, false);
Book EnHåndbokforLivet = new Book("En Håndbok for Livet", "Mark Manson", "978-8203370644", 2016, false);

Biblotek.LeggTilBok(HarryPotterogDevisesstein);
Biblotek.LeggTilBok(RingenesHerre);
Biblotek.LeggTilBok(Sult);
Biblotek.LeggTilBok(Fugletribunalet);
Biblotek.LeggTilBok(EnHåndbokforLivet);

User Anne = new User("Anne Berit Olsen", 101, new List<Book>());
User Per = new User("Per Erik Hansen", 102, new List<Book>());
User Silje = new User("Silje Marie Jensen", 103, new List<Book>());
User Karl = new User("Karl Johan Nilsen", 104, new List<Book>());

Biblotek.RegistrerBruker(Anne);
Biblotek.RegistrerBruker(Per);
Biblotek.RegistrerBruker(Silje);
Biblotek.RegistrerBruker(Karl);



Biblotek.LånUtBok("978-8202170367",101);

Biblotek.LånUtBok("978-8202170367",102);

Biblotek.LånUtBok("978-8203223049",102);

Biblotek.LeverInnBok("978-8203370644",101);
Biblotek.LeverInnBok("978-8202170367",101);

Biblotek.LeverInnBok("978-8203370644",103);

Biblotek.VisAlleBrukere();
Anne.VisLånteBøker();
Per.VisLånteBøker();
Biblotek.VisAlleBøker();


